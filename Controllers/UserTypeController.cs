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
    public class UserTypeController : ControllerBase
    {
        IUserTypeBusinessLogic UserTypeBusinessLogic;

        public UserTypeController(IUserTypeBusinessLogic Repo)
        {
            UserTypeBusinessLogic =Repo;
        }
        [Route("DeleteUserTypes/{Id}")]
        [HttpDelete]
        public int DeleteUserType(int id)
        {
            return UserTypeBusinessLogic.DeleteUserType(id);
        }


        [Route("GetUserTypesById/{Id}")]
        [HttpGet]
        public UserType GetByUserTypeId(int id)
        {
            return UserTypeBusinessLogic.GetByUserTypeId(id);
        }


        [Route("GetUserTypes")]
        [HttpGet]
        public List<UserType> GetUserTypes()
        {
            return UserTypeBusinessLogic.GetUserTypes();
        }


        [Route("AddUserTypes")]
        [HttpPost]
        public bool InsertUserType(UserType UserType)
        {
            return UserTypeBusinessLogic.InsertUserType(UserType);
        }


        [Route("UpdateUserTypes")]
        [HttpPut]
        public bool UpdateUserType(UserType UserType)
        {
           
                return UserTypeBusinessLogic.UpdateUserType(UserType);
           
        }
}}
