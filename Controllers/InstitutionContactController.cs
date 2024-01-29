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
    public class InstitutionContactController : ControllerBase
    {
        IInstitutionContactBussinessLogic InstitutionContactRepository;
        public InstitutionContactController(IInstitutionContactBussinessLogic Repo)
        {
            InstitutionContactRepository = Repo;
        }

        [Route("DeleteInstitutionContacts/{Id}")]
        [HttpDelete]
        public int DeleteInstitutionContact(int id)
        {
            return InstitutionContactRepository.DeleteInstitutionContact(id);
        }


        [Route("GetInstitutionContactsById/{Id}")]
        [HttpGet]
        public InstitutionContact GetByInstitutionContactId(int id)
        {
            return InstitutionContactRepository.GetByInstitutionContactId(id);
        }

      



        [Route("GetInstitutionContacts")]
        [HttpGet]
        public List<InstitutionContact> GetInstitutionContacts()
        {
            return InstitutionContactRepository.GetInstitutionContacts();
        }


        [Route("AddInstitutionContacts")]
        [HttpPost]
        public int InsertInstitutionContact(InstitutionContact institutionContact)
        {
            return InstitutionContactRepository.InsertInstitutionContact(institutionContact);
        }


        [Route("UpdateInstitutionContacts")]
        [HttpPut]
        public int UpdateInstitutionContact(InstitutionContact institutionContact)
        {
            return InstitutionContactRepository.UpdateInstitutionContact(institutionContact);
        }

        [Route("GetInstitutionContactList")]
        [HttpGet]
        public List<InstitutionContactList> GetInstitutionContactList()
        {
            return InstitutionContactRepository.GetInstitutionContactList();
        }


        [Route("GetInstitutionContactsByAddressId/{AddressId}")]
        [HttpGet]
        public List<InstitutionContact> GetInstitutionContactsByAddressId(int AddressId)
        {
            return InstitutionContactRepository.GetInstitutionContactsByAddressId(AddressId);
        }
    }
}
