using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyContactController : ControllerBase
    {
        IFamilyContactBusinessLogic family;
        public FamilyContactController(IFamilyContactBusinessLogic Repo)
        {
            family = Repo;
        }

        [Route("DeleteFamilyContacts/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return family.DeleteUser(id);
        }


        [Route("GetFamilyContactsById/{Id}")]
        [HttpGet]
        public FamilyContact GetByUserId(int id)
        {
            return family.GetByUserId(id);
        }


        [Route("GetFamilyContacts")]
        [HttpGet]
        public List<FamilyContact> GetUsers()
        {
            return family.GetUsers();
        }


        [Route("AddFamilyContacts")]
        [HttpPost]
        public bool InsertUser(FamilyContact user)
        {
            return family.InsertUser(user);
        }


        [Route("UpdateFamilyContacts")]
        [HttpPut]
        public bool UpdateUser(FamilyContact user)
        {
            return family.UpdateUser(user);
        }
    }
}
