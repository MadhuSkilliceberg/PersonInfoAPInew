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
   // [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionContactController : ControllerBase
    {
      private readonly  IInstitutionContactBussinessLogic _institutionContactBussinessLogic;
        public InstitutionContactController(IInstitutionContactBussinessLogic institutionContactBussinessLogic)
        {
            _institutionContactBussinessLogic = institutionContactBussinessLogic;
        }

        [Route("DeleteInstitutionContactByInstitutionContactId/{institutionContactId}")]
        [HttpDelete]
        public async Task<int> DeleteInstitutionContactByInstitutionContactId(int institutionContactId)

        {
            return await _institutionContactBussinessLogic.DeleteInstitutionContactByInstitutionContactId(institutionContactId);
        }


        [Route("GetInstitutionContactByInstitutionContactId/{institutionContactId}")]
        [HttpGet]
        public async Task<InstitutionContact> GetInstitutionContactByInstitutionContactId(int institutionContactId)

        {
            return await _institutionContactBussinessLogic.GetInstitutionContactByInstitutionContactId(institutionContactId);
        }

      



        [Route("GetInstitutionContacts")]
        [HttpGet]
        public async Task<List<InstitutionContact>> GetInstitutionContacts()

        {
            return await _institutionContactBussinessLogic.GetInstitutionContacts();
        }


        [Route("AddInstitutionContact")]
        [HttpPost]
        public async Task<int> AddInstitutionContact(InstitutionContact institutionContact)

        {
            return await _institutionContactBussinessLogic.AddInstitutionContact(institutionContact);
        }


        [Route("UpdateInstitutionContact")]
        [HttpPut]
        public async Task<int> UpdateInstitutionContact(InstitutionContact institutionContact)

        {
            return await _institutionContactBussinessLogic.UpdateInstitutionContact(institutionContact);
        }

        [Route("GetInstitutionContactList")]
        [HttpGet]
        public async  Task<List<InstitutionContactList>> GetInstitutionContactList()
        {
            return await _institutionContactBussinessLogic.GetInstitutionContactList();
        }


        [Route("GetInstitutionContactsByAddressId/{AddressId}")]
        [HttpGet]
        public async Task<List<InstitutionContact>> GetInstitutionContactsByAddressId(int addressId)

        {
            return await _institutionContactBussinessLogic.GetInstitutionContactsByAddressId(addressId);
        }


        [Route("AddRangeInstitutionContacts")]
        [HttpPost]
        public async Task<bool> AddRangeInstitutionContacts(List<InstitutionContact> institutionContacts)
        {
            return await _institutionContactBussinessLogic.AddRangeInstitutionContacts(institutionContacts);
        }

        [Route("UpdateRangeInstitutionContacts")]
        [HttpPut]
        public async Task<bool> UpdateRangeInstitutionContacts(List<InstitutionContact> institutionContacts)
        {
            return await _institutionContactBussinessLogic.UpdateRangeInstitutionContacts(institutionContacts);
        }

        [Route("DeleteRangeInstitutionContacts")]
        [HttpDelete]
        public async Task<bool> DeleteRangeInstitutionContacts(List<InstitutionContact> institutionContacts)
        {
            return await _institutionContactBussinessLogic.DeleteRangeInstitutionContacts(institutionContacts);
        }



    }
}
