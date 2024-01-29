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
    public class CourseController : ControllerBase
    {
        ICourseBusinessLogic coursebusinessLogic;

        public CourseController(ICourseBusinessLogic Repo)
        {
            coursebusinessLogic = Repo;
        }

        [Route("DeleteCourses/{id}")]
        [HttpDelete]
        public int Deletecourse(int id)
        {
            return coursebusinessLogic.Deletecourse(id);
        }

        [Route("GetCoursesById/{id}")]
        [HttpGet]
        public Course GetBycourseId(int id)
        {
            return coursebusinessLogic.GetBycourseId(id);
        }

        [Route("GetCourses")]
        [HttpGet]
        public List<Course> GetCourse()
        {
            return coursebusinessLogic.GetCourse();
        }

        [Route("Addcourses")]
        [HttpPost]
        public int Insertcourse(Course course)
        {
            return coursebusinessLogic.Insertcourse(course);
        }

        [Route("Updatecourses")]
        [HttpPut]
        public int Updatecourse(Course course)
        {
            return coursebusinessLogic.Updatecourse(course);
        }
    }
}
