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
        public int DeleteSkill(int id)
        {
            return userRepository.DeleteSkill(id);
        }


        [Route("GetSkillsById/{Id}")]
        [HttpGet]
        public Skill GetBySkillId(int id)
        {
            return userRepository.GetSkillById(id);
        }



        [Route("GetSkills")]
        [HttpGet]
        public List<Skill> GetSkills()
        {
            return userRepository.GetSkills();
        }


        [Route("AddSkills")]
        [HttpPost]
        public int InsertSkill(Skill user)
        {
            return userRepository.InsertSkill(user);
        }


        [Route("UpdateSkills")]
        [HttpPut]
        public int UpdateSkill(Skill user)
        {
            return userRepository.UpdateSkill(user);
        }

        [Route("GetSkillsSearch/{name}")]
        [HttpGet]
        public List<Skill> GetSkillsSearch(string name)
        {
            return userRepository.GetSkillsSearch(name);
        }

       

    }
}
