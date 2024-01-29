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
    public class UserEmailController : ControllerBase
    {
        IUserEmailBussinessLogic userRepository;
        public UserEmailController(IUserEmailBussinessLogic Repo)
        {
            userRepository = Repo;
        }

        [Route("DeleteUserEmails/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }


        [Route("GetUserEmailsById/{Id}")]
        [HttpGet]
        public UserEmail GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }


        [Route("GetUserEmails")]
        [HttpGet]
        public List<UserEmail> GetUsers()
        {
            return userRepository.GetUsers();
        }


        [Route("AddUserEmails")]
        [HttpPost]
        public bool InsertUser(UserEmail user)
        {
            return userRepository.InsertUser(user);
        }


        [Route("UpdateUserEmails")]
        [HttpPut]
        public bool UpdateUser(UserEmail user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
