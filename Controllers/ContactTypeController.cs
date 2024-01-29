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
    public class ContactTypeController : ControllerBase
    {
        IContactTypeBusinessLogic ContactTypeBusinessLogic;

        public ContactTypeController(IContactTypeBusinessLogic Repo)
        {
            ContactTypeBusinessLogic = Repo;
        }
        [Route("DeleteContactType/{id}")]
        [HttpDelete]
        public int DeleteContactType(int id)
        {
            return ContactTypeBusinessLogic.DeleteContactType(id);
        }


        [Route("GetContactTypeById/{id}")]
        [HttpGet]
        public ContactType GetByContactTypeId(int id)
        {
            return ContactTypeBusinessLogic.GetByContactTypeId(id);
        }


        [Route("GetContactTypes")]
        [HttpGet]
        public List<ContactType> GetContactTypes()
        {
            return ContactTypeBusinessLogic.GetContactTypes();
        }


        [Route("AddContactType")]
        [HttpPost]
        public bool InsertContactType(ContactType ContactType)
        {
            return ContactTypeBusinessLogic.InsertContactType(ContactType);
        }


        [Route("UpdateContactType")]
        [HttpPut]
        public bool UpdateContactType(ContactType ContactType)
        {

            return ContactTypeBusinessLogic.UpdateContactType(ContactType);

        }
    }
}
