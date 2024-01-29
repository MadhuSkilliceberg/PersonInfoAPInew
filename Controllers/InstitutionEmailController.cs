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
    public class InstitutionEmailController : ControllerBase
    {
        IInstitutionEmailBussinessLogic institutionEmailBussinessLogic;
        public InstitutionEmailController(IInstitutionEmailBussinessLogic institutionEmailBussinessLogic)
        {
           this. institutionEmailBussinessLogic = institutionEmailBussinessLogic;
        }


        [Route("DeleteInstitutionEmails")]
        [HttpDelete]
        public int DeleteInstitutionEmail(int id)
        {
            return institutionEmailBussinessLogic.DeleteInstitutionEmail(id);
        }


        [Route("GetInstitutionEmailsById/{id}")]
        [HttpGet]
        public InstitutionEmail GetByInstitutionEmailId(int id)
        {
            return institutionEmailBussinessLogic.GetByInstitutionEmailId(id);
        }

      


        [Route("GetInstitutionEmails")]
        [HttpGet]
        public List<InstitutionEmail> GetInstitutionEmails()
        {
            return institutionEmailBussinessLogic.GetInstitutionEmails();
        }


        [Route("AddInstitutionEmails")]
        [HttpPost]
        public int InsertInstitutionEmail(InstitutionEmail institutionEmail)
        {
            return institutionEmailBussinessLogic.InsertInstitutionEmail(institutionEmail);
        }


        [Route("UpdateInstitutionEmails")]
        [HttpPut]
        public int UpdateInstitutionEmail(InstitutionEmail institutionEmail)
        {
            return institutionEmailBussinessLogic.UpdateInstitutionEmail(institutionEmail);
        }

        [Route("GetInstitutionEmailList")]
        [HttpGet]
        public List<InstitutionEmailList> GetInstitutionEmailList()
        {
            return institutionEmailBussinessLogic.GetInstitutionEmailList();
        }

        [Route("GetInstitutionEmailsByAddressId/{addressId}")]
        [HttpGet]
        public List<InstitutionEmail> GetInstitutionEmailsByAddressId(int addressId)
        {
            return institutionEmailBussinessLogic.GetInstitutionEmailsByAddressId(addressId);
        }

    }
}
