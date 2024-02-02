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
  //  [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionEmailController : ControllerBase
    {
      private readonly  IInstitutionEmailBussinessLogic _institutionEmailBussinessLogic;
        public InstitutionEmailController(IInstitutionEmailBussinessLogic institutionEmailBussinessLogic)
        {
            _institutionEmailBussinessLogic = institutionEmailBussinessLogic;
        }


        [Route("DeleteInstitutionEmailByInstitutionEmailId/{institutionEmailId}")]
        [HttpDelete]
        public async Task<int> DeleteInstitutionEmailByInstitutionEmailId(int institutionEmailId)

        {
            return await _institutionEmailBussinessLogic.DeleteInstitutionEmailByInstitutionEmailId(institutionEmailId);
        }


        [Route("GetInstitutionEmailIdByinstitutionEmailId/{institutionEmailId}")]
        [HttpGet]
        public async Task<InstitutionEmail> GetInstitutionEmailIdByinstitutionEmailId(int institutionEmailId)

        {
            return await _institutionEmailBussinessLogic.GetInstitutionEmailIdByinstitutionEmailId(institutionEmailId);
        }

      


        [Route("GetInstitutionEmails")]
        [HttpGet]
        public async Task<List<InstitutionEmail>> GetInstitutionEmails()

        {
            return await _institutionEmailBussinessLogic.GetInstitutionEmails();
        }


        [Route("AddInstitutionEmail")]
        [HttpPost]
        public async Task<int> AddInstitutionEmail(InstitutionEmail institutionEmail)

        {
            return await _institutionEmailBussinessLogic.AddInstitutionEmail(institutionEmail);
        }


        [Route("UpdateInstitutionEmail")]
        [HttpPut]
        public async Task<int> UpdateInstitutionEmail(InstitutionEmail institutionEmail)

        {
            return await _institutionEmailBussinessLogic.UpdateInstitutionEmail(institutionEmail);
        }

        [Route("GetInstitutionEmailList")]
        [HttpGet]
        public async Task<List<InstitutionEmailList>> GetInstitutionEmailList()
        {
            return await _institutionEmailBussinessLogic.GetInstitutionEmailList();
        }

        [Route("GetInstitutionEmailsByAddressId/{addressId}")]
        [HttpGet]
        public Task<List<InstitutionEmail>> GetInstitutionEmailsByAddressId(int addressId)

        {
            return _institutionEmailBussinessLogic.GetInstitutionEmailsByAddressId(addressId);
        }

        [Route("UpdateRangeInstitutionEmails")]
       [HttpPut]
        public async Task<bool> UpdateRangeInstitutionEmails(List<InstitutionEmail> institutionEmails)
        {
            return await _institutionEmailBussinessLogic.UpdateRangeInstitutionEmails(institutionEmails);
        }

        [Route("AddRangeInstitutionEmails")]
        [HttpPost]
        public async Task<bool> AddRangeInstitutionEmails(List<InstitutionEmail> institutionEmails)
        {
            return await _institutionEmailBussinessLogic.AddRangeInstitutionEmails(institutionEmails);
        }

        [Route("DeleteRangeInstitutionEmails")]
        [HttpDelete]
        public async Task<bool> DeleteRangeInstitutionEmails(List<InstitutionEmail> institutionEmails)
        {
            return await _institutionEmailBussinessLogic.DeleteRangeInstitutionEmails(institutionEmails);
        }




    }
}
