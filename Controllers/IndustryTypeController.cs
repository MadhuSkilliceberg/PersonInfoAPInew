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
    public class IndustryTypeController : ControllerBase
    {
        IIndustryTypeBusinessLogic IndustryTypeBusinessLogic;

        public IndustryTypeController(IIndustryTypeBusinessLogic Repo)
        {
            IndustryTypeBusinessLogic =Repo;
        }
        [Route("DeleteIndustryTypes/{Id}")]
        [HttpDelete]
        public int DeleteIndustryType(int id)
        {
            return IndustryTypeBusinessLogic.DeleteIndustryType(id);
        }


        [Route("GetIndustryTypesById/{Id}")]
        [HttpGet]
        public IndustryType GetByIndustryTypeId(int id)
        {
            return IndustryTypeBusinessLogic.GetByIndustryTypeId(id);
        }


        [Route("GetIndustryTypes")]
        [HttpGet]
        public List<IndustryType> GetIndustryTypes()
        {
            return IndustryTypeBusinessLogic.GetIndustryTypes();
        }


        [Route("AddIndustryTypes")]
        [HttpPost]
        public int InsertIndustryType(IndustryType IndustryType)
        {
            return IndustryTypeBusinessLogic.InsertIndustryType(IndustryType);
        }


        [Route("UpdateIndustryTypes")]
        [HttpPut]
        public bool UpdateIndustryType(IndustryType IndustryType)
        {
           
                return IndustryTypeBusinessLogic.UpdateIndustryType(IndustryType);
           
        }
}}
