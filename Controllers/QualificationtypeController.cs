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
        public int DeleteQulificationType(int id)
        {
            return qualification.DeleteQulificationType(id);
        }


        [Route("GetQulificationTypeById/{Id}")]
        [HttpGet]
        public QulificationType GetQulificationTypeById(int id)
        {
            return qualification.GetQulificationTypeById(id);
        }


        [Route("GetQulificationTypes")]
        [HttpGet]
        public List<QulificationType> GetQulificationTypes()
        {
            return qualification.GetQulificationTypes();
        }


        [Route("AddQulificationType")]
        [HttpPost]
        public int InsertQulificationType(QulificationType qualificationtype)
        {
            return qualification.InsertQulificationType(qualificationtype);
        }


        [Route("UpdateQulificationType")]
        [HttpPut]
        public int UpdateQulificationType(QulificationType qualificationtype)
        {
            return qualification.UpdateQulificationType(qualificationtype);
        }


    }
}
