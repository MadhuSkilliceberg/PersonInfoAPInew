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
    public class DepartmentController : ControllerBase
    {
        IDepartmentBusinessLogic DepartmentBusinessLogic;

        public DepartmentController(IDepartmentBusinessLogic Repo)
        {
            DepartmentBusinessLogic =Repo;
        }
        [Route("DeleteDepartments/{Id}")]
        [HttpDelete]
        public int DeleteDepartment(int id)
        {
            return DepartmentBusinessLogic.DeleteDepartment(id);
        }


        [Route("GetDepartmentsById/{Id}")]
        [HttpGet]
        public Department GetByDepartmentId(int id)
        {
            return DepartmentBusinessLogic.GetByDepartmentId(id);
        }


        [Route("GetDepartments")]
        [HttpGet]
        public List<Department> GetDepartment()
        {
            return DepartmentBusinessLogic.GetDepartment();
        }


        [Route("AddDepartments")]
        [HttpPost]
        public int InsertDepartment(Department Department)
        {
            return DepartmentBusinessLogic.InsertDepartment(Department);
        }


        [Route("UpdateDepartments")]
        [HttpPut]
        public bool UpdateDepartment(Department Department)
        {
           
                return DepartmentBusinessLogic.UpdateDepartment(Department);
           
        }
}}
