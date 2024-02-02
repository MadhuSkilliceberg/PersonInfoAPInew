using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyContactController : ControllerBase
    {
        private readonly ICompanyContactBussinessLogic companyContactBussinessLogic;

        public CompanyContactController(ICompanyContactBussinessLogic  companyContactBussinessLogic)
        {
            this.companyContactBussinessLogic = companyContactBussinessLogic;
        }


        [Route("DeleteCompanyContact/{id}")]
        [HttpDelete]
        public async Task<bool> DeleteCompanyContact(int id)
        {
            return await companyContactBussinessLogic.DeleteCompanyContact(id);
        }

        [Route("DeleteRangeCompanyContact")]
        [HttpDelete]
        public async Task<bool> DeleteRangeCompanyContact(List<int> ids)
        {
            return await companyContactBussinessLogic.DeleteRangeCompanyContact(ids);
        }


        [Route("GetCompanyContacts")]
        [HttpGet]
        public async Task<List<CompanyContact> >GetCompanyContacts()
        {
            return await companyContactBussinessLogic.GetCompanyContacts();
        }


        [Route("AddCompanyContact")]
        [HttpPost]
        public async Task<int> AddCompanyContact(CompanyContact companyContact)
        {
            return await companyContactBussinessLogic.AddCompanyContact(companyContact);
        }

        [Route("AddRangeCompanyContact")]
        [HttpPost]
        public async Task<int> AddRangeCompanyContact(List<CompanyContact> companyContacts)
        {
            return await companyContactBussinessLogic.AddRangeCompanyContact(companyContacts);
        }


        [Route("UpdateCompanyContact")]
        [HttpPut]
        public async Task<int> UpdateCompanyContact(CompanyContact companyContact)
        {
            return await companyContactBussinessLogic.UpdateCompanyContact(companyContact);
        }

        [Route("UpdateRangeCompanyContact")]
        [HttpPut]
        public async Task<int> UpdateRangeCompanyContact(CompanyContact companyContact)
        {
            return await companyContactBussinessLogic.UpdateCompanyContact(companyContact);
        }

        [Route("GetCompanyContactByCompanyAddressId/{companyaddressId}")]
        [HttpGet]
        public async Task<List<CompanyContact> >GetCompanyContactByCompanyAddressId(int companyaddressId)
        {
            return await companyContactBussinessLogic.GetCompanyContactByCompanyAddressId(companyaddressId);
        }

        [Route("GetCompanyContactById/{id}")]
        [HttpGet]
        public async Task<CompanyContact> GetCompanyContactById(int id)
        {
            return await companyContactBussinessLogic.GetCompanyContactById(id);
        }
    }
}
