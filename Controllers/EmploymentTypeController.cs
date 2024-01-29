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
    public class EmploymentTypeController : ControllerBase
    {
        IEmploymentTypeBusinessLogic EmploymentTypeBusinessLogic;

        public EmploymentTypeController(IEmploymentTypeBusinessLogic Repo)
        {
            EmploymentTypeBusinessLogic =Repo;
        }
        [Route("DeleteEmploymentTypes/{Id}")]
        [HttpDelete]
        public int DeleteEmploymentType(int id)
        {
            return EmploymentTypeBusinessLogic.DeleteEmploymentType(id);
        }


        [Route("GetEmploymentTypesById/{Id}")]
        [HttpGet]
        public EmploymentType GetByEmploymentTypeId(int id)
        {
            return EmploymentTypeBusinessLogic.GetByEmploymentTypeId(id);
        }


        [Route("GetEmploymentTypes")]
        [HttpGet]
        public List<EmploymentType> GetEmploymentTypes()
        {
            return EmploymentTypeBusinessLogic.GetEmploymentTypes();
        }


        [Route("AddEmploymentTypes")]
        [HttpPost]
        public int InsertEmploymentType(EmploymentType EmploymentType)
        {
            return EmploymentTypeBusinessLogic.InsertEmploymentType(EmploymentType);
        }


        [Route("UpdateEmploymentTypes")]
        [HttpPut]
        public bool UpdateEmploymentType(EmploymentType EmploymentType)
        {
           
                return EmploymentTypeBusinessLogic.UpdateEmploymentType(EmploymentType);
           
        }
}}
