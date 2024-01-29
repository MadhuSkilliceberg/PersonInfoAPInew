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
    public class VacanciesSkillController : ControllerBase
    {
        IVacanciesSkillBusinessLogic VacanciesSkillBusinessLogic;

        public VacanciesSkillController(IVacanciesSkillBusinessLogic Repo)
        {
            VacanciesSkillBusinessLogic = Repo;
        }
        [Route("DeleteVacanciesSkill/{id}")]
        [HttpDelete]
        public int DeleteVacanciesSkill(int id)
        {
            return VacanciesSkillBusinessLogic.DeleteVacanciesSkill(id);
        }


        [Route("GetVacanciesSkillById/{id}")]
        [HttpGet]
        public VacanciesSkill GetByVacanciesSkillId(int id)
        {
            return VacanciesSkillBusinessLogic.GetByVacanciesSkillId(id);
        }


        [Route("GetVacanciesSkill")]
        [HttpGet]
        public List<VacanciesSkill> GetVacanciesSkills()
        {
            return VacanciesSkillBusinessLogic.GetVacanciesSkills();
        }


        [Route("AddVacanciesSkill")]
        [HttpPost]
        public int InsertVacanciesSkill(VacanciesSkill VacanciesSkill)
        {
            return VacanciesSkillBusinessLogic.InsertVacanciesSkill(VacanciesSkill);
        }


        [Route("UpdateVacanciesSkill")]
        [HttpPut]
        public bool UpdateVacanciesSkill(VacanciesSkill VacanciesSkill)
        {
           
                return VacanciesSkillBusinessLogic.UpdateVacanciesSkill(VacanciesSkill);
           
        }
}}
