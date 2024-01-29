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
    public class QualificationtypeController : ControllerBase
    {
        IQualificationtypeBussinessLogic qualification;

     public   QualificationtypeController(IQualificationtypeBussinessLogic Repo)
        {
            qualification = Repo;

        }
        [Route("DeleteQulificationType/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return qualification.DeleteUser(id);
        }


        [Route("GetQulificationTypeById/{Id}")]
        [HttpGet]
        public QulificationType GetByUserId(int id)
        {
            return qualification.GetByUserId(id);
        }


        [Route("GetQulificationType")]
        [HttpGet]
        public List<QulificationType> GetUsers()
        {
            return qualification.GetUsers();
        }


        [Route("AddQulificationType")]
        [HttpPost]
        public int InsertUser(QulificationType qualificationtype)
        {
            return qualification.InsertUser(qualificationtype);
        }


        [Route("UpdateQulificationType")]
        [HttpPut]
        public int UpdateUser(QulificationType qualificationtype)
        {
            return qualification.UpdateUser(qualificationtype);
        }


    }
}
