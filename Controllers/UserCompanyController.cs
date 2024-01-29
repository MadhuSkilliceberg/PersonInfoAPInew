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
    public class UserCompanyController : ControllerBase
    {
        IUserCompanyBusinessLogic usercompany;

        public  UserCompanyController(IUserCompanyBusinessLogic Repo)
        {
            usercompany = Repo;
        }
        [Route("DeleteUserCompany/{id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return usercompany.DeleteUser(id);
        }


        [Route("GetByUserCompanyId/{id}")]
        [HttpGet]
        public UserCompany GetByUserId(int id)
        {
            return usercompany.GetByUserId(id);
        }


        [Route("GetUserCompanys")]
        [HttpGet]
        public List<UserCompany> GetUsers()
        {
            return usercompany.GetUsers();
        }


        [Route("AddUserCompany")]
        [HttpPost]
        public int InsertUser(UserCompany user)
        {
            return usercompany.InsertUser(user);
        }


        [Route("UpdateUserCompany")]
        [HttpPut]
        public int UpdateUser(UserCompany user)
        {
            return usercompany.UpdateUser(user);
        }
    }
}
