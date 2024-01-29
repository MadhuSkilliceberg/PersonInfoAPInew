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
    public class UserSkillController : ControllerBase
    {
        IUserSkillBusinessLogic skillBusinessLogic;

        public UserSkillController(IUserSkillBusinessLogic Repo)
        {
            skillBusinessLogic =Repo;
        }
        [Route("DeleteUserSkills/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return skillBusinessLogic.DeleteUser(id);
        }


        [Route("GetUserSkillsById/{Id}")]
        [HttpGet]
        public UserSkill GetByUserId(int id)
        {
            return skillBusinessLogic.GetByUserId(id);
        }


        [Route("GetUserSkills")]
        [HttpGet]
        public List<UserSkill> GetUsers()
        {
            return skillBusinessLogic.GetUsers();
        }


        [Route("AddUserSkills")]
        [HttpPost]
        public int InsertUser(UserSkill user)
        {
            return skillBusinessLogic.InsertUser(user);
        }


        [Route("UpdateUserSkills")]
        [HttpPut]
        public int UpdateUser(UserSkill user)
        {
           
                return skillBusinessLogic.UpdateUser(user);
           
        }
}}
