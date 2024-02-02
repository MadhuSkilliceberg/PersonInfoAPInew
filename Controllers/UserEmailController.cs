using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PersonsInfoV2Api.BussinessLogic;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class UserEmailController : ControllerBase
    {
        IUserEmailBussinessLogic userEmailBussinessLogic;
        public UserEmailController(IUserEmailBussinessLogic Repo)
        {
            userEmailBussinessLogic = Repo;
        }

        [Route("DeleteUserEmails/{Id}")]
        [HttpDelete]
        public async  Task<int> DeleteUserEmails(int id)
        {
            return await userEmailBussinessLogic.DeleteUserEmails(id);
        }


        [Route("GetUserEmailsById/{Id}")]
        [HttpGet]
        public async Task<UserEmail> GetUserEmailById(int id)
        {
            return await userEmailBussinessLogic.GetUserEmailById(id);
        }
         

        [Route("GetUserEmails")]
        [HttpGet]
        public async Task<List<UserEmail>> GetUserEmails()
        {
            return await userEmailBussinessLogic.GetUserEmails();
        }


        [Route("AddUserEmail")]
        [HttpPost]
        public async Task<int> AddUserEmail(UserEmail userEmail )
        {
            return await userEmailBussinessLogic.AddUserEmail(userEmail);
        }


        [Route("UpdateUserEmail")]
        [HttpPut]
        public async Task<int> UpdateUserEmail(UserEmail userEmail)
        {
            return await userEmailBussinessLogic.UpdateUserEmail(userEmail);
        }

        [Route("AddUserEmails")]
        [HttpPost]
        public async Task<int> AddUserEmails(List<UserEmail> userEmails )
        {
            return await userEmailBussinessLogic.AddUserEmails(userEmails);
        }


        [Route("UpdateUserEmails")]
        [HttpPut]
        public async Task<int> UpdateUserEmail(List<UserEmail> userEmails)
        {
            return await userEmailBussinessLogic.UpdateUserEmails(userEmails);
        }

        [Route("AddUpdateUserEmail")]
        [HttpPut]
        public async Task<int> AddUpdateUserEmail(UserEmail userEmail)
        {
            if (userEmail == null)
            {
                var data = userEmail.Id > 0 ? await userEmailBussinessLogic.UpdateUserEmail(userEmail) : await userEmailBussinessLogic.AddUserEmail(userEmail);
            }
            return 1;
        }

        [Route("AddOrUpdateUserEmails")]
        [HttpPut]
        public async Task<int> AddOrUpdateUserEmails(List<UserEmail> userEmails)
        {
            if (userEmails == null)
            {
                await userEmailBussinessLogic.UpdateUserEmails(userEmails.Where(ad => ad.Id > 0).ToList());
                await userEmailBussinessLogic.AddUserEmails(userEmails.Where(ad => ad.Id < 1).ToList());

            }
            return 1;
        }


    }
}
