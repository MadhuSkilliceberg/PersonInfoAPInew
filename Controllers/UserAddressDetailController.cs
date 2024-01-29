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
    public class UserAddressDetailController : ControllerBase
    {
        IUserAddressDetailBusinessLogic userAddress;

        public  UserAddressDetailController(IUserAddressDetailBusinessLogic Repo)
        {
            userAddress = Repo;
        }

        [Route("DeleteUserAddressDetails/{id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return userAddress.DeleteUser(id);
        }


        [Route("GetUserAddressDetailsById/{id}")]
        [HttpGet]
        public UserAddressDetail GetByUserId(int id)
        {
            return userAddress.GetByUserId(id);
        }


        [Route("GetUserAddressDetails")]
        [HttpGet]
        public List<UserAddressDetail> GetUsers()
        {
            return userAddress.GetUsers();
        }


        [Route("AddUserAddressDetails")]
        [HttpPost]
        public bool InsertUser(UserAddressDetail user)
        {
            return userAddress.InsertUser(user);
        }


        [Route("UpdateUserAddressDetails")]
        [HttpPut]
        public bool UpdateUser(UserAddressDetail user)
        {
            return userAddress.UpdateUser(user);
        }

    }
}
