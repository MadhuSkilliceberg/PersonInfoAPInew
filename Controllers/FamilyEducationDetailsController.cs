using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyEducationDetailsController : ControllerBase
    {
        IFamilyEducationDetailBusinessLogic detailBusinessLogic;

            public FamilyEducationDetailsController(IFamilyEducationDetailBusinessLogic Repo)
        {
            detailBusinessLogic = Repo;
                
        }



        [Route("DeleteFamilyEducationDetails/{Id}")]
        [HttpDelete]
        public int DeleteFamilyEducationDetail(int id)
        {
            return detailBusinessLogic.DeleteFamilyEducationDetail(id);
        }



        [Route("GetFamilyEducationDetailsById/{Id}")]
        [HttpGet]
        public FamilyEducationDetail GetById(int id)
        {
            return detailBusinessLogic.GetById(id);
        }

        [Route("GetFamilyEducationDetails")]
        [HttpGet]
        public List<FamilyEducationDetail> GetFamilyEducationDetail()
        {
            return detailBusinessLogic.GetFamilyEducationDetail();
        }


        [Route("AddFamilyEducationDetails")]
        [HttpPost]
        public int InsertFamilyEducationDetail(FamilyEducationDetail detail)
        {
            return detailBusinessLogic.InsertFamilyEducationDetail(detail);
        }


        [Route("UpdateFamilyEducationDetails")]
        [HttpPut]
        public int UpdateFamilyEducationDetail(FamilyEducationDetail detail)
        {
            return detailBusinessLogic.UpdateFamilyEducationDetail(detail);
        }
    }
}
