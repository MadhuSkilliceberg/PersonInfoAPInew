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
    public class RoleController : ControllerBase
    {
        IRoleBusinessLogic RoleBusinessLogic;

        public RoleController(IRoleBusinessLogic Repo)
        {
            RoleBusinessLogic =Repo;
        }
        [Route("DeleteRoles/{Id}")]
        [HttpDelete]
        public int DeleteRole(int id)
        {
            return RoleBusinessLogic.DeleteRole(id);
        }


        [Route("GetRolesById/{Id}")]
        [HttpGet]
        public Role GetByRoleId(int id)
        {
            return RoleBusinessLogic.GetByRoleId(id);
        }


        [Route("GetRoles")]
        [HttpGet]
        public List<Role> GetRoles()
        {
            return RoleBusinessLogic.GetRoles();
        }


        [Route("AddRoles")]
        [HttpPost]
        public int InsertRole(Role Role)
        {
            return RoleBusinessLogic.InsertRole(Role);
        }


        [Route("UpdateRoles")]
        [HttpPut]
        public bool UpdateRole(Role Role)
        {
           
                return RoleBusinessLogic.UpdateRole(Role);
           
        }
}}
