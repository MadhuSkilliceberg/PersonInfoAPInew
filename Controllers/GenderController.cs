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
    public class GenderController : ControllerBase
    {
        IGenderBussinessLogic userRepository;
        public GenderController(IGenderBussinessLogic Repo)
        {
            userRepository = Repo;
        }


        [Route("DeleteGender/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }


        [Route("GetGenderById/{Id}")]
        [HttpGet]
        public Gender GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }


        [Route("GetGender")]
        [HttpGet]
        public List<Gender> GetUsers()
        {
            return userRepository.GetUsers();
        }


        [Route("AddGender")]
        [HttpPost]
        public bool InsertUser(Gender user)
        {
            return userRepository.InsertUser(user);
        }


        [Route("UpdateGender")]
        [HttpPut]
        public bool UpdateUser(Gender user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
