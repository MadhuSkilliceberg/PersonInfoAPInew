using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IUserCourseBusinessLogic
    {
        public List<UserCourse> GetUserCourse();
        public int InsertUserCourse(UserCourse userCourse);

        public int UpdateUserCourse(UserCourse userCourse);

        public int DeleteUserCourse(int id);

        public UserCourse GetByUserCourseId(int id);

        public List<UserCourseList> GetUserCourseList();
    }
}
