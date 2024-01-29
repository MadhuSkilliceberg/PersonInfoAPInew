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
        ICompanyContactBussinessLogic userRepository;
        public CompanyContactController(ICompanyContactBussinessLogic Repo)
        {
            userRepository = Repo;
        }


        [Route("DeleteCompanyContacts/{id}")]
        [HttpDelete]
        public int DeleteCompanyContact(int id)
        {
            return userRepository.DeleteCompanyContact(id);
        }


        [Route("GetCompanyContacts")]
        [HttpGet]
        public List<CompanyContact> GetCompanyContacts()
        {
            return userRepository.GetCompanyContacts();
        }


        [Route("AddCompanyContacts")]
        [HttpPost]
        public int InsertCompanyContact(CompanyContact companyContact)
        {
            return userRepository.InsertCompanyContact(companyContact);
        }


        [Route("UpdateCompanyContacts")]
        [HttpPut]
        public bool UpdateCompanyContact(CompanyContact companyContact)
        {
            return userRepository.UpdateCompanyContact(companyContact);
        }

        [Route("GetCompanyContactsByCompanyAddressId/{companyaddressId}")]
        [HttpGet]
        public List<CompanyContact> GetCompanyContactsByCompanyAddressId(int companyaddressId)
        {
            return userRepository.GetCompanyContactsByCompanyAddressId(companyaddressId);
        }

        [Route("GetCompanyContactsById/{id}")]
        [HttpGet]
        public CompanyContact GetCompanyContactsById(int id)
        {
            return userRepository.GetCompanyContactsById(id);
        }
    }
}
