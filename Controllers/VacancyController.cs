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
    public class VacancyController : ControllerBase
    {
        IVacancyBusinessLogic VacancyBusinessLogic;

        public VacancyController(IVacancyBusinessLogic Repo)
        {
            VacancyBusinessLogic =Repo;
        }
        [Route("DeleteVacancies/{Id}")]
        [HttpDelete]
        public int DeleteVacancy(int id)
        {
            return VacancyBusinessLogic.DeleteVacancy(id);
        }


        [Route("GetVacanciesById/{Id}")]
        [HttpGet]
        public Vacancy GetByVacancyId(int id)
        {
            return VacancyBusinessLogic.GetByVacancyId(id);
        }


        [Route("GetVacancies")]
        [HttpGet]
        public List<Vacancy> GetVacancys()
        {
            return VacancyBusinessLogic.GetVacancys();
        }


        [Route("AddVacancies")]
        [HttpPost]
        public int InsertVacancy(Vacancy Vacancy)
        {
            return VacancyBusinessLogic.InsertVacancy(Vacancy);
        }


        [Route("UpdateVacancies")]
        [HttpPut]
        public bool UpdateVacancy(Vacancy Vacancy)
        {
           
                return VacancyBusinessLogic.UpdateVacancy(Vacancy);
           
        }
}}
