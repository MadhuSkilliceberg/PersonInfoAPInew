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
    public class UserEducationDetailsController : ControllerBase
    {
        IUserEducationDetailLogics user1;

        public UserEducationDetailsController(IUserEducationDetailLogics Logic)
        {
            user1 = Logic;
        }


        [Route("DeleteUserEducationDetails/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return user1.DeleteUser(id);
        }

        [Route("GetUserEducationDetailsById/{Id}")]
        [HttpGet]
        public UserEducationDetail GetByUserId(int id)
        {
            return user1.GetByUserId(id);
        }

        [Route("GetUserEducationDetails")]
        [HttpGet]
        public List<UserEducationDetail> GetUsers()
        {
            return user1.GetUsers();
        }

        [Route("AddUserEducationDetails")]
        [HttpPost]
        public int InsertUser(UserEducationDetail user)
        {
            return user1.InsertUser(user);
        }

        [Route("UpdateUserEducationDetails")]
        [HttpPut]
        public int UpdateUser(UserEducationDetail user)
        {
            return user1.UpdateUser(user);
        }
    }
}

