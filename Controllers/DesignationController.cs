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
    public class DesignationController : ControllerBase
    {
        IDesignationBusinessLogic businessLogic;

        public DesignationController(IDesignationBusinessLogic Repo)
        {
            businessLogic =Repo;

        }

        [Route("DeleteDesignation/{id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return businessLogic.DeleteUser(id);
        }


        [Route("GetDesignationById/{id}")]
        [HttpGet]
        public Designation GetByUserId(int id)
        {
            return businessLogic.GetByUserId(id);
        }


        [Route("GetDesignation")]
        [HttpGet]
        public List<Designation> GetUsers()
        {
            return businessLogic.GetUsers();
        }


        [Route("AddDesignation")]
        [HttpPost]
        public int InsertUser(Designation user)
        {
            return businessLogic.InsertUser(user);
        }


        [Route("UpdateDesignation")]
        [HttpPut]
        public int UpdateUser(Designation user)
        {
            return businessLogic.UpdateUser(user);
        }
    }
}
