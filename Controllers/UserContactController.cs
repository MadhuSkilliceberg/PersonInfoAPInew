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

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class UserContactController : ControllerBase
    {
         IUserContactBussinessLogic Logic;
        public UserContactController(IUserContactBussinessLogic use)
        {
            Logic = use;
        }

        [Route("DeleteUserContacts/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return Logic.DeleteUser(id);
        }


        [Route("GetUserContactsById/{id}")]
        [HttpGet]
        public UserContact GetByUserId(int id)
        {
            return Logic.GetByUserId(id);
        }


        [Route("GetUserContacts")]
        [HttpGet]
        public List<UserContact> GetUsers()
        {
            return Logic.GetUsers();
        }


        [Route("AddUserContacts")]
        [HttpPost]
        public bool InsertUser(UserContact user)
        {
            return Logic.InsertUser(user);
        }


        [Route("UpdateUserContacts")]
        [HttpPut]
        public bool UpdateUser(UserContact user)
        {
            return Logic.UpdateUser(user);
        }
    }
}
