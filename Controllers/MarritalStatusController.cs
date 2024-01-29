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
    public class MarritalStatusController : ControllerBase
    {
        IMarritalStatusBussinessLogic userRepository;
        public MarritalStatusController(IMarritalStatusBussinessLogic Repo)
        {
            userRepository = Repo;
        }

        [Route("DeleteMarritalStatus/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }


        [Route("GetMarritalStatusById/{Id}")]
        [HttpGet]
        public MarritalStatus GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }


        [Route("GetMarritalStatus")]
        [HttpGet]
        public List<MarritalStatus> GetUsers()
        {
            return userRepository.GetUsers();
        }


        [Route("AddMarritalStatus")]
        [HttpPost]
        public bool InsertUser(MarritalStatus user)
        {
            return userRepository.InsertUser(user);
        }


        [Route("UpdateMarritalStatus")]
        [HttpPut]
        public bool UpdateUser(MarritalStatus user)
        {
            return userRepository.UpdateUser(user);
        }

    }
}
