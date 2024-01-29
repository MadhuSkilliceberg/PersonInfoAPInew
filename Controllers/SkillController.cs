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
    public class SkillController : ControllerBase
    {
        ISkillBussinessLogic userRepository;
        public SkillController(ISkillBussinessLogic Repo)
        {
            userRepository = Repo;
        }


        [Route("DeleteSkills/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }


        [Route("GetSkillsById/{Id}")]
        [HttpGet]
        public Skill GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }


        [Route("GetSkills")]
        [HttpGet]
        public List<Skill> GetUsers()
        {
            return userRepository.GetUsers();
        }


        [Route("AddSkills")]
        [HttpPost]
        public int InsertUser(Skill user)
        {
            return userRepository.InsertUser(user);
        }


        [Route("UpdateSkills")]
        [HttpPut]
        public int UpdateUser(Skill user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
