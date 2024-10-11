using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;
using PersonsInfoV2Api.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace PersonsInfoV2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationUsersController : ControllerBase
    {

        private readonly IJwtAuth jwtAuth;
        private readonly IUserBussinessLogic userBussinessLogic;
        private readonly IUserTokenSessionBussinessLogic _userTokenSessionBussinessLogic;

        //private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthenticationUsersController(
            IJwtAuth jwtAuth,
            IUserBussinessLogic userBussinessLogic,
            IUserTokenSessionBussinessLogic userTokenSessionBussinessLogic
            )
        {
            this.jwtAuth = jwtAuth;
            this.userBussinessLogic = userBussinessLogic;
            _userTokenSessionBussinessLogic = userTokenSessionBussinessLogic;
            //_httpContextAccessor = httpContextAccessor;
        }


        [AllowAnonymous]
        // POST api/<MembersController>
        [HttpPost("authentication")]
        public IActionResult Authentication([FromBody] UserCredential userCredential)
        {
            // Example in a controller action
            //HttpContext.Session.SetString("Test", "Value");
            //var testValue = HttpContext.Session.GetString("Test"); // Should return "Value"
            //string deviceInfo=string.Empty;
            Request.Headers.TryGetValue("Device-Info", out StringValues deviceInfo);
            userCredential.userDevice = JsonConvert.DeserializeObject<UserDevice>(deviceInfo.ToString());

            // Retrieve the remote IP address of the user
            //var ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress?.ToString();

            AuthenticatedResponse token = jwtAuth.Authentication(userCredential);
            if (token == null)
                return Unauthorized();
            else
            {
                var user = userBussinessLogic.GetByUserId(token.UserId);
                // Convert object to JSON string
                //string userJsonString = JsonSerializer.Serialize(user);
                //HttpContext.Session.SetString("UserData", userJsonString);
                //HttpContext.Session.SetString("token", token.ToString());
                //HttpContext.Session.SetString("UserId", token.UserId.ToString());
                return Ok(token);
            }
        }


        [Authorize]
        [HttpPost("logout/this-device")]
        public async Task<IActionResult> LogoutFromThisDevice()
        {
            // Get the current token from the request
            var accessToken = Request.Headers["Authorization"].ToString().Replace("bearer ", "");


            Task<IEnumerable<UserTokenSession>> task = _userTokenSessionBussinessLogic.GeUserTokenSessionsAsync();

            // Await the Task and convert the IEnumerable to a List
            IEnumerable<UserTokenSession> userTokenSessions = await task;
            List<UserTokenSession> userTokenSessionList = userTokenSessions.ToList();

            // Retrieve the current session based on the token
            var tokenSession = userTokenSessionList.FirstOrDefault(x => x.AccessToken == accessToken && x.IsActive == true);

            if (tokenSession != null)
            {
                // Mark the session as inactive
                tokenSession.IsActive = false;
                tokenSession.UpdatedOn = DateTime.UtcNow;

                await _userTokenSessionBussinessLogic.UpdateUserTokenSessionAsync(tokenSession);

                return Ok(new { message = "Successfully logged out from this device." });
            }

            return BadRequest(new { message = "Invalid token or session already ended." });
        }


        [Authorize]
        [HttpPost("logout/all-devices")]
        public async Task<IActionResult> LogoutFromAllDevices()
        {
            // Get the current logged-in user id from the token claims
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

            Task<IEnumerable<UserTokenSession>> task = _userTokenSessionBussinessLogic.GeUserTokenSessionsAsync();
            // Await the Task and convert the IEnumerable to a List
            IEnumerable<UserTokenSession> userTokenSessions = await task;
            List<UserTokenSession> userTokenSessionList = userTokenSessions.ToList();

            // Retrieve the current session based on the token
            // Retrieve all active token sessions for the user
            var activeSessions = userTokenSessionList.Where(x => x.UserId == userId && x.IsActive == true).ToList();

            if (activeSessions.Any())
            {
                // Mark all sessions as inactive
                foreach (var session in activeSessions)
                {
                    session.IsActive = false;
                    session.UpdatedOn = DateTime.UtcNow;
                    await _userTokenSessionBussinessLogic.UpdateUserTokenSessionAsync(session);
                }
                return Ok(new { message = "Successfully logged out from all devices." });
            }

            return BadRequest(new { message = "No active sessions found." });
        }

    }
}
