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
    public class FamilyEmailController : ControllerBase
    {
        IFamilyEmailbusinessLogic logic;
        public FamilyEmailController(IFamilyEmailbusinessLogic repo)
        {
            logic = repo;
        }



        [Route("DeleteFamilyEmails/{Id}")]
        [HttpDelete]
        public int DeleteFamilyEmail(int id)
        {
            return logic.DeleteFamilyEmail(id);
        }


        [Route("GetFamilyEmailsById/{Id}")]
        [HttpGet]
        public FamilyEmail GetById(int id)
        {
            return logic.GetById(id);
        }

        [Route("GetFamilyEmails")]
        [HttpGet]
        public List<FamilyEmail> GetFamilyEmails()
        {
            return logic.GetFamilyEmails();
        }


        [Route("AddFamilyEmails")]
        [HttpPost]
        public int InsertFamilyEmail(FamilyEmail email)
        {
            return logic.InsertFamilyEmail(email);
        }


        [Route("UpdateFamilyEmails")]
        [HttpPut]
        public int UpdateFamilyEmail(FamilyEmail email)
        {
            return logic.UpdateFamilyEmail(email);
        }
    }
}
