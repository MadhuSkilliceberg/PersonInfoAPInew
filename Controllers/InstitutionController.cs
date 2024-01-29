using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;
using Microsoft.AspNetCore.Authorization;

namespace PersonsInfoV2Api.Controllers
{ 
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionController : ControllerBase
    {
        IInstitutionBussinessLogic InstitutionRepository;
        public InstitutionController(IInstitutionBussinessLogic Repo)
        {
            InstitutionRepository = Repo;
        }


        [Route("DeleteInstitutions/{id}")]
        [HttpDelete]
        public int DeleteInstitutions(int id)
        {
            return InstitutionRepository.DeleteInstitution(id);
        }


        [Route("GetInstitutionsById/{id}")]
        [HttpGet]
        public Institution GetInstitutionsById(int id)
        {
            return InstitutionRepository.GetByInstitutionId(id);
        }


        [Route("GetInstitutions")]
        [HttpGet]
        public List<Institution> GetInstitutions()
        {
            return InstitutionRepository.GetInstitutions();
        }


        [Route("AddInstitutions")]
        [HttpPost]
        public int AddInstitutions(Institution institution)
        {
            return InstitutionRepository.InsertInstitution(institution);
        }


        [Route("UpdateInstitutions")]
        [HttpPut]
        public int UpdateInstitutions(Institution institution)
        {
            return InstitutionRepository.UpdateInstitution(institution);
        }


        [Route("GetQualificationcs")]
        [HttpGet]
        public List<Qualificationcs> GetQualificationcs()
        {
            return InstitutionRepository.GetQualificationcs();
        }

        [Route("AddInstitutionModel")]
        [HttpPost]
        public bool AddInstitutionModel(InstitutionModels institutionModels)
        {
            return InstitutionRepository.InstitutionModel(institutionModels);
        }

        [Route("AddInstitutionDetails")]
        [HttpPost]
        public bool AddInstitutionDetails([FromBody]InstitutionDetails institutionDetails)
         {
            return InstitutionRepository.InstitutionDetails(institutionDetails);
        }

    }
}
