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
        ICompanyBussinessLogic companyRepo;
        public CompanyController(ICompanyBussinessLogic Repo)
        {
            companyRepo = Repo;
        }


        [Route("DeleteCompany/{id}")]
        [HttpDelete]
        public int DeleteCompany(int id)
        {
            return companyRepo.DeleteCompany(id);
        }

        [Route("GetByCompanyId/{id}")]
        [HttpGet]
        public Company GetByCompanyId(int id)
        {
            return companyRepo.GetByCompanyId(id);

        }


        [Route("GetCompany")]
        [HttpGet]
        public List<Company> GetCompanys()
        {
            return companyRepo.GetCompanys();
        }


        [Route("AddCompany")]
        [HttpPost]
        public int InsertCompany(Company  company)
        {
            return companyRepo.InsertCompany(company);
        }


        [Route("UpdateCompany")]
        [HttpPut]
        public int UpdateCompany(Company company)
        {
            return companyRepo.UpdateCompany(company);
        }

        [Route("AddCompanyDetail")]
        [HttpPost]
        public bool AddCompanyDetail(CompanyDetail companyDetail)
        {
            return companyRepo.AddCompanyDetail(companyDetail);
        }

        [Route("AddCompanyTables")]
        [HttpPost]

        public bool AddCompanyTables(CompanyModels companyModels)
        {
            return companyRepo.AddCompanyTables(companyModels);
        }

    }
}
