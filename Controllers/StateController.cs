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
    public class StateController : ControllerBase
    {
        IStateBussinessLogic userRepository;
        public StateController(IStateBussinessLogic Repo)
        {
            userRepository = Repo;
        }


        [Route("DeleteStates/{id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }


        [Route("GetStatesById/{id}")]
        [HttpGet]
        public State GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }


        [Route("GetStates")]
        [HttpGet]
        public List<State> GetUsers()
        {
            return userRepository.GetUsers();
        }


        [Route("AddStates")]
        [HttpPost]
        public bool InsertUser(State user)
        {
            return userRepository.InsertUser(user);
        }


        [Route("UpdateStates")]
        [HttpPut]
        public bool UpdateUser(State user)
        {
            return userRepository.UpdateUser(user);
        }



        [Route("GetAllFamilyDetailsByPuttingUser")]
        [HttpGet]
        public List<string> GetAllFamilyDetailsByPuttingUser(string username)
        {
            return userRepository.GetAllFamilyDetailsByPuttingUser(username);
        }
    }
}
