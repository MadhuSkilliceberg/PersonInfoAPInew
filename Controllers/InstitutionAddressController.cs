using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
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
    public class InstitutionAddressController : ControllerBase
    {
        IInstitutionAddressBusinessLogic InstitutionAddressRepository;
        public InstitutionAddressController(IInstitutionAddressBusinessLogic repo)
        {
            InstitutionAddressRepository = repo;
        }

        [Route("DeleteInstitutionAddress/{Id}")]
        [HttpDelete]
        public int DeleteInstitutionAddress(int id)
        {
            return InstitutionAddressRepository.DeleteInstitutionAddress(id);
        }


        [Route("GetInstitutionAddressById/{Id}")]  
        [HttpGet]
        public InstitutionAddress GetInstitutionAddressById(int id)
        {
            return InstitutionAddressRepository.GetByInstitutionAddressId(id);
        }



        [Route("GetInstitutionAddress")]
        [HttpGet]
        public List<InstitutionAddress> GetInstitutionAddress()
        {
            return InstitutionAddressRepository.GetInstitutionAddresss();
        }


        [Route("AddInstitutionAddress")]
        [HttpPost]
        public int AddInstitutionAddress(InstitutionAddress institutionAddress)
        {
            return InstitutionAddressRepository.InsertInstitutionAddress(institutionAddress);
        }


        [Route("UpdateInstitutionAddress")]
        [HttpPut]
        public int UpdateInstitutionAddress(InstitutionAddress institutionAddress)
        {
            return InstitutionAddressRepository.UpdateInstitutionAddress(institutionAddress);
        }

        [Route("GetInstitutionAddresslist")]
        [HttpGet]
        public List<InstitutionAddresslist> GetInstitutionAddresslist()
        {
            return InstitutionAddressRepository.GetInstitutionAddresslist();
        }


        [Route("GetInstitutionAddressByInstituteId/{instituteId}")]
        [HttpGet]
        public List<InstitutionAddress> GetInstitutionAddressByInstituteId(int instituteId)
        {
            return InstitutionAddressRepository.GetInstitutionAddressByInstituteId(instituteId);
        }

    }
    
}
