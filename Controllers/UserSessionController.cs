using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using PersonsInfoV2Api.Entities;
using System;
using System.Text.Json;

namespace PersonsInfoV2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSessionController : ControllerBase
    {
        //private readonly UserController userController;

        //public UserSessionController(UserController userController)
        //{
        //    this.userController = userController;
        //}

        [HttpPost("SetSessionUserData")]
        public IActionResult SetSessionUserData(User user)
        {
           // var user =  userController.GetByUserId(userId);
            // Convert object to JSON string
            string userJsonString = JsonSerializer.Serialize(user);
            HttpContext.Session.SetString("UserData", userJsonString);
            return Ok("Session data set.");
        }


        [HttpGet("GetSessionUserData")]
        //[ProducesResponseType<User>(StatusCodes.Status200OK)]

        public User GetSessionUserData()
        {
            HttpContext.Session.SetString("UserId", "Hi");
            string userData = HttpContext.Session.GetString("UserId");
          //  string userData = HttpContext.Session.GetString("UserData");
            if (userData != null)
            {
                // Deserialize JSON string to object
                User user = JsonSerializer.Deserialize<User>(userData);
                return user != null ? user : new User();
            }
            else
            {
                return new User();
            }
        }
    }



}
