using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
//using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class CyearController : ControllerBase
    {
        ICyearBusinessLogic cyearBusinessLogic;

        public CyearController(ICyearBusinessLogic logic)
        {
            cyearBusinessLogic = logic;
        }


        [Route("DeleteCyear/{Id}")]
        [HttpDelete]
        public int DeleteCyear(int id)
        {
            return cyearBusinessLogic.DeleteCyear(id);
        }



        [Route("GetCyearById/{Id}")]
        [HttpGet]
        public Cyear GetByCyearId(int id)
        {
            return cyearBusinessLogic.GetByCyearId(id);
        }


        [Route("GetCyear")]
        [HttpGet]
        public List<Cyear> GetCyears()
        {
            return cyearBusinessLogic.GetCyears();
        }


        [Route("AddCyear")]
        [HttpPost]
        public int InsertCyear(Cyear cyear)
        {
            return cyearBusinessLogic.InsertCyear(cyear);
        }


        [Route("UpdateCyear")]
        [HttpPut]
        public int UpdateCyear(Cyear cyear)
        {
            return cyearBusinessLogic.UpdateCyear(cyear);
        }
    }
}
