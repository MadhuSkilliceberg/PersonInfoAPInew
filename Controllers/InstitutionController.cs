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
   // [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionController : ControllerBase
    {
      private readonly  IInstitutionBussinessLogic _institutionBussinessLogic;
        public InstitutionController(IInstitutionBussinessLogic institutionBussinessLogic)
        {
            _institutionBussinessLogic = institutionBussinessLogic;
        }


        [Route("DeleteInstitutionByInstitutionId/{institutionId}")]
        [HttpDelete]
        public async Task<int> DeleteInstitutionByInstitutionId(int institutionId)

        {
            return await _institutionBussinessLogic.DeleteInstitutionByInstitutionId(institutionId);
        }


        [Route("GetInstitutionByInstitutionId/{institutionId}")]
        [HttpGet]
        public async Task<Institution> GetInstitutionByInstitutionId(int institutionId)

        {
            return await _institutionBussinessLogic.GetInstitutionByInstitutionId(institutionId);
        }


        [Route("GetInstitutions")]
        [HttpGet]
        public async Task<List<Institution>> GetInstitutions()

        {
            return await _institutionBussinessLogic.GetInstitutions();
        }


        [Route("AddInstitutions")]
        [HttpPost]
        public async Task<int> AddInstitution(Institution institution)

        {
            return await _institutionBussinessLogic.AddInstitution(institution);
        }


        [Route("UpdateInstitutions")]
        [HttpPut]
        public async Task<int> UpdateInstitution(Institution institution)

        {
            return await _institutionBussinessLogic.UpdateInstitution(institution);
        }


        [Route("GetQualificationcs")]
        [HttpGet]
        public async Task<List<Qualificationcs>> GetQualificationcs()

        {
            return await _institutionBussinessLogic.GetQualificationcs();
        }

        [Route("AddInstitutionModel")]
        [HttpPost]
        public async Task<bool> InstitutionModel(InstitutionModels institutionModels)

        {
            return await _institutionBussinessLogic.InstitutionModel(institutionModels);
        }

        [Route("AddInstitutionDetails")]
        [HttpPost]
        public async Task<bool> AddInstitutionDetails([FromBody]InstitutionDetails institutionDetails)
         {
            return await _institutionBussinessLogic.InstitutionDetails(institutionDetails);
        }

    }
}
