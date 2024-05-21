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
using PersonsInfoV2Api.Models;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class LookUpValueController : ControllerBase
    {
        ILookUpValueBussinessLogic LookUpValueRepository;
        public LookUpValueController(ILookUpValueBussinessLogic Repo)
        {
            LookUpValueRepository = Repo;
        }


        [Route("DeleteLookUpValue/{Id}")]
        [HttpDelete]
        public int DeleteLookUpValue(int id)
        {
            return LookUpValueRepository.DeleteLookUpValue(id);
        }


        [Route("GetLookUpValueById/{Id}")]
        [HttpGet]
        public LookUpValue GetByLookUpValueId(int id)
        {
            return LookUpValueRepository.GetByLookUpValueId(id);
        }


        [Route("GetLookUpValues")]
        [HttpGet]
        public List<LookUpValue> GetLookUpValues()
        {
            return LookUpValueRepository.GetLookUpValues();
        }


        [Route("AddLookUpValue")]
        [HttpPost]
        public bool InsertLookUpValue(LookUpValue LookUpValue)
        {
            return LookUpValueRepository.InsertLookUpValue(LookUpValue);
        }


        [Route("UpdateLookUpValue")]
        [HttpPut]
        public bool UpdateLookUpValue(LookUpValue LookUpValue)
        {
            return LookUpValueRepository.UpdateLookUpValue(LookUpValue);
        }

        [Route("GetLookUpValueByCode")]
        [HttpPost]
        public List<LookUpValue> GetLookUpValueByCode(List<string> codes)
        {
            return LookUpValueRepository.GetLookUpValueByCode(codes);
        }
        [Route("GetLookUpValueByLId/{Id}")]
        [HttpGet]
        public List<LookUpValue> GetLookUpValueByLId(int Id)
        {
            return LookUpValueRepository.GetLookUpValueByLId(Id);
        }

        [Route("GetLookUpValueByRoleCategory/{DepartmentId}")]
        [HttpGet]
        public List<LookUpValue> GetLookUpValueByRoleCategory(int DepartmentId)
        {
            return LookUpValueRepository.GetLookUpValueByRoleCategory(DepartmentId);
        }

        [Route("GetLookUpSearch")]
        [HttpPost]
        public List<LookUpValue> GetLookUpSearch(LookUpSearch lookUpSearch)
        {
            return LookUpValueRepository.GetLookUpSearch(lookUpSearch);
        }

    }
}
