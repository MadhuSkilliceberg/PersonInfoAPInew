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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyBussinessLogic companyBussinessLogic;

        public CompanyController(ICompanyBussinessLogic companyBussinessLogic)
        {
            this.companyBussinessLogic = companyBussinessLogic;
        }

        [Route("DeleteCompany/{id}")]
        [HttpDelete]
        public async Task<bool> DeleteCompany(int id)
        {
            return await companyBussinessLogic.DeleteCompany(id);
        }


        [Route("DeleteRangeCompany")]
        [HttpDelete]
        public async Task<bool> DeleteRangeCompany(List<int> ids)
        {
            return await companyBussinessLogic.DeleteRangeCompany(ids);
        }

        [Route("GetCompanyById/{id}")]
        [HttpGet]
        public async Task<Company> GetCompanyById(int id)
        {
            return await companyBussinessLogic.GetCompanyById(id);

        }

        [Route("GetCompanies")]
        [HttpGet]
        public async Task<List<Company>> GetCompanies()
        {
            return await companyBussinessLogic.GetCompanies();
        }

        [Route("AddCompany")]
        [HttpPost]
        public async Task<int> AddCompany(Company company)
        {
            return await companyBussinessLogic.AddCompany(company);
        }

        [Route("AddRangeCompany")]
        [HttpPost]
        public async Task<int> AddRangeCompany(List<Company> companies)
        {
            return await companyBussinessLogic.AddRangeCompany(companies);
        }


        [Route("UpdateCompany")]
        [HttpPut]
        public async Task<int> UpdateCompany(Company company)
        {
            return await companyBussinessLogic.UpdateCompany(company);
        }

        [Route("UpdateRangeCompany")]
        [HttpPut]
        public async Task<int> UpdateRangeCompany(List<Company> companies)
        {
            return await companyBussinessLogic.UpdateRangeCompany(companies);
        }

        [Route("AddCompanyDetail")]
        [HttpPost]
        public async Task<bool> AddCompanyDetail(CompanyDetail companyDetail)
        {
            return await companyBussinessLogic.AddCompanyDetail(companyDetail);
        }

        [Route("AddCompanyTables")]
        [HttpPost]
        public async Task<bool> AddCompanyTables(CompanyModels companyModels)
        {
            return await companyBussinessLogic.AddCompanyTables(companyModels);
        }

    }
}
