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
    public class LookUpController : ControllerBase
    {
        ILookUpBussinessLogic LookUpRepository;
        public LookUpController(ILookUpBussinessLogic Repo)
        {
            LookUpRepository = Repo;
        }


        [Route("DeleteLookUp/{Id}")]
        [HttpDelete]
        public int DeleteLookUp(int id)
        {
            return LookUpRepository.DeleteLookUp(id);
        }


        [Route("GetLookUpById/{Id}")]
        [HttpGet]
        public LookUp GetByLookUpId(int id)
        {
            return LookUpRepository.GetByLookUpId(id);
        }


        [Route("GetLookUp")]
        [HttpGet]
        public List<LookUp> GetLookUps()
        {
            return LookUpRepository.GetLookUps();
        }

        [Route("GetLookUps1")]
        [HttpGet]
        public object GetLookUps1()
        {
            return LookUpRepository.GetLookUps1();
        }

      
        [Route("AddLookUp")]
        [HttpPost]
        public bool InsertLookUp(LookUp LookUp)
        {
            return LookUpRepository.InsertLookUp(LookUp);
        }


        [Route("UpdateLookUp")]
        [HttpPut]
        public bool UpdateLookUp(LookUp LookUp)
        {
            return LookUpRepository.UpdateLookUp(LookUp);
        }
    }
}
