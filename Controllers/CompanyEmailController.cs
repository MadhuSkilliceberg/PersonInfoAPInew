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
        ICompanyEmailBussinessLogic userRepository;
        public CompanyEmailController(ICompanyEmailBussinessLogic Repo)
        {
            userRepository = Repo;
        }

        [Route("GetCompanyEmailById/{id}")]
        [HttpGet]
        public CompanyEmail GetCompanyEmailById(int id)
        {
            return userRepository.GetCompanyEmailById(id);
        }

        [Route("DeleteCompanyEmails/{id}")]
        [HttpDelete]
        public int DeleteCompanyEmail(int id)
        {
            return userRepository.DeleteCompanyEmail(id);
        }

        [Route("GetCompanyEmailByCompanyAddressId/{companyaddressId}")]
        [HttpGet]
        public List<CompanyEmail> GetCompanyEmailByCompanyAddressId(int companyaddressId)
        {
            return userRepository.GetCompanyEmailByCompanyAddressId(companyaddressId);
        }

        [Route("GetCompanyEmails")]
        [HttpGet]
        public List<CompanyEmail> GetCompanyEmails()
        {
            return userRepository.GetCompanyEmails();
        }


        [Route("AddCompanyEmail")]
        [HttpPost]
        public int AddCompanyEmail(CompanyEmail companyEmail)
        {
            return userRepository.InsertCompanyEmail(companyEmail);
        }


        [Route("UpdateCompanyEmail")]
        [HttpPut]
        public bool UpdateCompanyEmail(CompanyEmail companyEmail)
        {
            return userRepository.UpdateCompanyEmail(companyEmail);
        }

    }
}
