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
    public class CompanyAddressController : ControllerBase
    {
        ICompanyAddressBussinessLogic userRepository;
        public CompanyAddressController(ICompanyAddressBussinessLogic Repo)
        {
            userRepository = Repo;
        }

        [Route("DeleteCompanyAddress/{id}")]
        [HttpDelete]
        public int DeleteCompanyAddress(int id)
        {
            return userRepository.DeleteCompanyAddress(id);
        }


        [Route("GetCompanyAddressById/{id}")]
        [HttpGet]
        public CompanyAddress GetByCompanyAddressId(int id)
            {
            return userRepository.GetByCompanyAddressId(id);
        }


        [Route("GetCompanyAddress")]
        [HttpGet]
        public List<CompanyAddress> GetCompanyAddresss()
        {
            return userRepository.GetCompanyAddresss();
        }


        [Route("AddCompanyAddress")]
        [HttpPost]
        public int InsertCompanyAddress(CompanyAddress user)
        {
            return userRepository.InsertCompanyAddress(user);
        }


        [Route("UpdateCompanyAddress")]
        [HttpPut]
        public bool UpdateCompanyAddress(CompanyAddress user)
        {
            return userRepository.UpdateCompanyAddress(user);
        }


        [Route("GetCompanyAddressIdByCompanyId/{companyid}")]
        [HttpGet]
        public List<CompanyAddress> GetCompanyAddressIdByCompanyId(int companyid)
        {
            return userRepository.GetCompanyAddressIdByCompanyId(companyid);

        }


    }
}
