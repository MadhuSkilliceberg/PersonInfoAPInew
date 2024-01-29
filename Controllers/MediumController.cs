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
    public class MediumController : ControllerBase
    {
        IMediumBussinessLogic userRepository;
        public MediumController(IMediumBussinessLogic Repo)
        {
            userRepository = Repo;
        }


        [Route("DeleteMedium/{id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }



        [Route("GetMediumById/{Id}")]
        [HttpGet]
        public Medium GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }


        [Route("GetMedium")]
        [HttpGet]
        public List<Medium> GetUsers()
        {
            return userRepository.GetUsers();
        }



        [Route("GetMediumByUserName")]
        [HttpGet]
        public Medium GetByUserName(string mediumName)
        {
            return userRepository.GetByUserName(mediumName);

        }


        [Route("AddMedium")]
        [HttpPost]
        public bool InsertUser(Medium user)
        {
            return userRepository.InsertUser(user);
        }


        [Route("UpdateMedium")]
        [HttpPut]
        public bool UpdateUser(Medium user)
        {
            return userRepository.UpdateUser(user);
        }

    }
}
