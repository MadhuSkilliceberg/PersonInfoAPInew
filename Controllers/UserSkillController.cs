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
using PersonsInfoV2Api.BussinessLogic;

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
        public async Task<int> DeleteUserSkills(int id)
        {
            return await skillBusinessLogic.DeleteUserSkillById(id);
        }


        [Route("GetUserSkillById/{Id}")]
        [HttpGet]
        public async Task<UserSkill> GetUserSkillById(int id)
        {
            return await skillBusinessLogic.GetUserSkillById(id);
        }


        [Route("GetUserSkillsById/{Id}")]
        [HttpGet]
        public async Task<UserSkill> GetUserSkillsById(int id)
        {
            return await skillBusinessLogic.GetUserSkillById(id);
        }

        [Route("GetUserSkillsByUserId/{Id}")]
        [HttpGet]
        public async Task<List<UserSkill>> GetUserSkillsByUserId(int id)
        {
            return await skillBusinessLogic.GetUserSkillsByUserId(id);
        }


        [Route("GetUserSkills")]
        [HttpGet]
        public async Task<List<UserSkill>> GetUserSkills()
        {
            return await skillBusinessLogic.GetUserSkills();
        }

        [Route("AddUserSkill")]
        [HttpPost]
        public async Task<int> AddUserSkill(UserSkill userSkill)
        {
            return await skillBusinessLogic.AddUserSkill(userSkill);
        }

        [Route("AddUserSkills")]
        [HttpPost]
        public async Task<int> AddUserSkills(List<UserSkill> userSkills)
        {
            return await skillBusinessLogic.AddUserSkills(userSkills);
        }


        [Route("UpdateUserSkill")]
        [HttpPut]
        public async Task<int> UpdateUserSkill(UserSkill userSkill)
        {
           
                return await skillBusinessLogic.UpdateUserSkill(userSkill);
           
        }


        [Route("UpdateUserSkills")]
        [HttpPut]
        public async Task<int> UpdateUserSkills(List<UserSkill> userSkills)
        {

            return await skillBusinessLogic.UpdateUserSkills(userSkills);

        }


        [Route("AddUpdateUserSkill")]
        [HttpPut]
        public async Task<int> AddUpdateUserSkill(UserSkill UserSkill)
        {
            if (UserSkill == null)
            {
                var data = UserSkill.Id > 0 ? await skillBusinessLogic.UpdateUserSkill(UserSkill) : await skillBusinessLogic.AddUserSkill(UserSkill);
            }
            return  1;
        }

        [Route("AddOrUpdateUserSkills")]
        [HttpPut]
        public async Task<int> AddOrUpdateUserSkills(List<UserSkill> UserSkills)
        {
            if (UserSkills == null)
            {
                await skillBusinessLogic.UpdateUserSkills(UserSkills.Where(ad => ad.Id > 0).ToList());
                await skillBusinessLogic.AddUserSkills(UserSkills.Where(ad => ad.Id < 1).ToList());

            }
            return  1;
        }


    }
}
