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
    public class RoleCategoryController : ControllerBase
    {
        IRoleCategoryBusinessLogic RoleCategoryBusinessLogic;

        public RoleCategoryController(IRoleCategoryBusinessLogic Repo)
        {
            RoleCategoryBusinessLogic =Repo;
        }
        [Route("DeleteRoleCategory/{Id}")]
        [HttpDelete]
        public int DeleteRoleCategory(int id)
        {
            return RoleCategoryBusinessLogic.DeleteRoleCategory(id);
        }


        [Route("GetRoleCategoryById/{Id}")]
        [HttpGet]
        public RoleCategory GetByRoleCategoryId(int id)
        {
            return RoleCategoryBusinessLogic.GetByRoleCategoryId(id);
        }


        [Route("GetRoleCategorys")]
        [HttpGet]
        public List<RoleCategory> GetRoleCategorys()
        {
            return RoleCategoryBusinessLogic.GetRoleCategorys();
        }


        [Route("AddRoleCategory")]
        [HttpPost]
        public int InsertRoleCategory(RoleCategory RoleCategory)
        {
            return RoleCategoryBusinessLogic.InsertRoleCategory(RoleCategory);
        }


        [Route("UpdateRoleCategory")]
        [HttpPut]
        public bool UpdateRoleCategory(RoleCategory RoleCategory)
        {
           
                return RoleCategoryBusinessLogic.UpdateRoleCategory(RoleCategory);
           
        }
}}
