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
    public class UserCourseController : ControllerBase
    {
        IUserCourseBusinessLogic usercourse;

        public UserCourseController(IUserCourseBusinessLogic logic)
        {
            usercourse = logic;
        }
        [Route("DeleteUserCourses/{id}")]
        [HttpDelete]
        public int DeleteUserCourse(int id)
        {
            return usercourse.DeleteUserCourse(id);
        }



        [Route("GetUserCoursesById/{id}")]
        [HttpGet]
        public UserCourse GetByUserCourseId(int id)
        {
            return usercourse.GetByUserCourseId(id);
        }

        [Route("GetUserCourses")]
        [HttpGet]
        public List<UserCourse> GetUserCourse()
        {
            return usercourse.GetUserCourse();
        }


        [Route("AddUserCourses")]
        [HttpPost]
        public int InsertUserCourse(UserCourse userCourse)
        {
            return usercourse.InsertUserCourse(userCourse);
        }


        [Route("UpdateUserCourses")]
        [HttpPut]
        public int UpdateUserCourse(UserCourse userCourse)
        {
            return usercourse.UpdateUserCourse(userCourse);
        }


        [Route("GetUserCourseList")]
        [HttpGet]
        public List<UserCourseList> GetUserCourseList()
        {
            return usercourse.GetUserCourseList();
        }
    }
}
