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
    public class TemplateTypeController : ControllerBase
    {
        ITemplateTypeBusinessLogic TemplateTypeBusinessLogic;

        public TemplateTypeController(ITemplateTypeBusinessLogic Repo)
        {
            TemplateTypeBusinessLogic =Repo;
        }
        [Route("DeleteTemplateType/{Id}")]
        [HttpDelete]
        public int DeleteTemplateType(int id)
        {
            return TemplateTypeBusinessLogic.DeleteTemplateType(id);
        }


        [Route("GetTemplateTypeById/{Id}")]
        [HttpGet]
        public TemplateType GetByTemplateTypeId(int id)
        {
            return TemplateTypeBusinessLogic.GetByTemplateTypeId(id);
        }


        [Route("GetTemplateType")]
        [HttpGet]
        public List<TemplateType> GetTemplateTypes()
        {
            return TemplateTypeBusinessLogic.GetTemplateTypes();
        }


        [Route("AddTemplateType")]
        [HttpPost]
        public int InsertTemplateType(TemplateType TemplateType)
        {
            return TemplateTypeBusinessLogic.InsertTemplateType(TemplateType);
        }


        [Route("UpdateTemplateType")]
        [HttpPut]
        public bool UpdateTemplateType(TemplateType TemplateType)
        {
           
                return TemplateTypeBusinessLogic.UpdateTemplateType(TemplateType);
           
        }
}}
