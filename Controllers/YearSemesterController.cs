using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;
using Microsoft.AspNetCore.Authorization;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class YearSemesterController : ControllerBase
    {
        IYearSemesterBusinessLogic YearsemesterBusiness;

        public YearSemesterController(IYearSemesterBusinessLogic logic)
        {
            YearsemesterBusiness = logic;
        }
        [Route("DeleteYearSemester/{id}")]
        [HttpDelete]
        public int DeleteYearSemester(int id)
        {
            return YearsemesterBusiness.DeleteYearSemester(id);
        }


        [Route("GetYearSemesterById/{id}")]
        [HttpGet]
        public YearSemester GetByYearSemesterId(int id)
        {
            return YearsemesterBusiness.GetByYearSemesterId(id);
        }


        [Route("GetYearSemester")]
        [HttpGet]
        public List<YearSemester> GetYearSemester()
        {
            return YearsemesterBusiness.GetYearSemester();
        }



        [Route("AddYearSemester")]
        [HttpPost]
        public int InsertYearSemester(YearSemester yearSemester)
        {
            return YearsemesterBusiness.InsertYearSemester(yearSemester);
        }


        [Route("UpdateYearSemester")]
        [HttpPut]
        public int UpdateYearSemester(YearSemester yearSemester)
        {
            return YearsemesterBusiness.UpdateYearSemester(yearSemester);
        }


        [Route("GetYearSemesterLists")]
        [HttpGet]
        public List<YearsemisemisterList> GetyearsemisemisterLists()
        {
            return YearsemesterBusiness.GetyearsemisemisterLists();
        }
    }
}
