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
    public class CompanyEmailController : ControllerBase
    {
        private readonly ICompanyEmailBussinessLogic companyEmailBussinessLogic;

        public CompanyEmailController(ICompanyEmailBussinessLogic companyEmailBussinessLogic)
        {
            this.companyEmailBussinessLogic = companyEmailBussinessLogic;
        }

        [Route("GetCompanyEmailById/{id}")]
        [HttpGet]
        public async Task<CompanyEmail> GetCompanyEmailById(int id)
        {
            return await companyEmailBussinessLogic.GetCompanyEmailById(id);
        }

        [Route("DeleteCompanyEmail/{id}")]
        [HttpDelete]
        public async Task<int> DeleteCompanyEmail(int id)
        {
            return await companyEmailBussinessLogic.DeleteCompanyEmail(id);
        }

        [Route("DeleteRangeCompanyEmail")]
        [HttpDelete]
        public async Task<int> DeleteRangeCompanyEmail(List<int> ids)
        {
            return await companyEmailBussinessLogic.DeleteRangeCompanyEmail(ids);
        }

        [Route("GetCompanyEmailByCompanyAddressId/{companyaddressId}")]
        [HttpGet]
        public async Task<List<CompanyEmail>> GetCompanyEmailByCompanyAddressId(int companyaddressId)
        {
            return await companyEmailBussinessLogic.GetCompanyEmailByCompanyAddressId(companyaddressId);
        }

        [Route("GetCompanyEmails")]
        [HttpGet]
        public async Task<List<CompanyEmail>> GetCompanyEmails()
        {
            return await companyEmailBussinessLogic.GetCompanyEmails();
        }

        [Route("AddCompanyEmail")]
        [HttpPost]
        public async Task<int> AddCompanyEmail(CompanyEmail companyEmail)
        {
            return await companyEmailBussinessLogic.AddCompanyEmail(companyEmail);
        }

        [Route("AddRangeCompanyEmail")]
        [HttpPost]
        public async Task<int> AddRangeCompanyEmail(List<CompanyEmail> companyEmails)
        {
            return await companyEmailBussinessLogic.AddRangeCompanyEmail(companyEmails);
        }


        [Route("UpdateCompanyEmail")]
        [HttpPut]
        public async Task<int> UpdateCompanyEmail(CompanyEmail companyEmail)
        {
            return await companyEmailBussinessLogic.UpdateCompanyEmail(companyEmail);
        }

        [Route("UpdateRangeCompanyEmail")]
        [HttpPut]
        public async Task<int> UpdateRangeCompanyEmail(List<CompanyEmail> companyEmails)
        {
            return await companyEmailBussinessLogic.UpdateRangeCompanyEmail(companyEmails);
        }

    }
}
