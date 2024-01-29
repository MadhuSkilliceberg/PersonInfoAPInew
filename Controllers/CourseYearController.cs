using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
 
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
    public class CourseYearController : ControllerBase
    {
        ICourseYearBusinessLogic courseYearBusinessLogic;

        public CourseYearController(ICourseYearBusinessLogic logic)
        {
            courseYearBusinessLogic = logic;
        }
        [Route("DeleteCourseYear/{id}")]
        [HttpDelete]
        public int DeleteCourseYear(int id)
        {
            return courseYearBusinessLogic.DeleteCourseYear(id);
        }



        [Route("GetCourseYearById/{id}")]
        [HttpGet]
        public CourseYear GetCourseYear(int id)
        {
            return courseYearBusinessLogic.GetByCourseYearId(id);
        }


        [Route("GetCourseYear")]
        [HttpGet]
        public List<CourseYear> GetCourseYears()
        {
            return courseYearBusinessLogic.GetCourseYears();
        }


        [Route("AddCourseYear")]
        [HttpPost]
        public int InsertCourseYear(CourseYear courseYear)
        {
            return courseYearBusinessLogic.InsertCourseYear(courseYear);
        }

        [Route("UpdateCourseYear")]
        [HttpPut]
        public int UpdateCourseYear(CourseYear courseYear)
        {
            return courseYearBusinessLogic.UpdateCourseYear(courseYear);
        }



        [Route("GetcouresYearLists")]
        [HttpGet]
        public List<CouresYearList> GetcouresYearLists()
        {
            return courseYearBusinessLogic.GetcouresYearLists();
        }
    }
}
