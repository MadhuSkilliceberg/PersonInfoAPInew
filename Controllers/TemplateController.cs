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
    public class TemplateController : ControllerBase
    {
        ITemplateBusinessLogic TemplateBusinessLogic;

        public TemplateController(ITemplateBusinessLogic Repo)
        {
            TemplateBusinessLogic =Repo;
        }
        [Route("DeleteTemplate/{Id}")]
        [HttpDelete]
        public int DeleteTemplate(int id)
        {
            return TemplateBusinessLogic.DeleteTemplate(id);
        }


        [Route("GetTemplateById/{Id}")]
        [HttpGet]
        public Template GetByTemplateId(int id)
        {
            return TemplateBusinessLogic.GetByTemplateId(id);
        }


        [Route("GetTemplate")]
        [HttpGet]
        public List<Template> GetTemplates()
        {
            return TemplateBusinessLogic.GetTemplates();
        }


        [Route("AddTemplate")]
        [HttpPost]
        public int InsertTemplate(Template Template)
        {
            return TemplateBusinessLogic.InsertTemplate(Template);
        }


        [Route("UpdateTemplate")]
        [HttpPut]
        public bool UpdateTemplate(Template Template)
        {
           
                return TemplateBusinessLogic.UpdateTemplate(Template);
           
        }
}}
