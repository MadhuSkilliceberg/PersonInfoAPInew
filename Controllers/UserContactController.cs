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
    public class UserContactController : ControllerBase
    {
         IUserContactBussinessLogic userContactBussinessLogic;
        public UserContactController(IUserContactBussinessLogic use)
        {
            userContactBussinessLogic = use;
        }

        [Route("DeleteUserContactById/{id}")]
        [HttpDelete]
        public async Task<int> DeleteUserContactById(int id)
        {
            return await userContactBussinessLogic.DeleteUserContactById(id);
        }


        [Route("GetUserContactById/{id}")]
        [HttpGet]
        public async Task<UserContact> GetUserContactById(int id)
        {
            return await userContactBussinessLogic.GetUserContactById(id);
        }


        [Route("GetUserContacts")]
        [HttpGet]
        public async Task<List<UserContact>> GetUserContacts()
        {
            return await userContactBussinessLogic.GetUserContacts();
        }


        [Route("AddUserContact")]
        [HttpPost]
        public async Task<int> AddUserContact(UserContact user)
        {
            return await userContactBussinessLogic.AddUserContact(user);
        }


        [Route("UpdateUserContact")]
        [HttpPut]
        public async Task<int> UpdateUserContact(UserContact userContact)
        {
            return await userContactBussinessLogic.UpdateUserContact(userContact);
        }

        [Route("AddUserContacts")]
        [HttpPost]
        public async Task<int> AddUserContacts(List<UserContact> userContacts)
        {
            return await userContactBussinessLogic.AddUserContacts(userContacts);
        }


        [Route("UpdateUserContacts")]
        [HttpPut]
        public async Task<int> UpdateUserContacts(List<UserContact> userContacts)
        {
            return await userContactBussinessLogic.UpdateUserContacts(userContacts);
        }

        [Route("AddUpdateUserContact")]
        [HttpPut]
        public async Task<int> AddUpdateUserContact(UserContact userContact)
        {
            if (userContact == null)
            {
                var data = userContact.Id > 0 ? await userContactBussinessLogic.UpdateUserContact(userContact) : await userContactBussinessLogic.AddUserContact(userContact);
            }
            return 1;
        }

        [Route("AddOrUpdateUserContacts")]
        [HttpPut]
        public async Task<int> AddOrUpdateUserContacts(List<UserContact> userContacts)
        {
            if (userContacts == null)
            {
                await userContactBussinessLogic.UpdateUserContacts(userContacts.Where(ad => ad.Id > 0).ToList());
                await userContactBussinessLogic.AddUserContacts(userContacts.Where(ad => ad.Id < 1).ToList());

            }
            return 1;
        }

    }
}
