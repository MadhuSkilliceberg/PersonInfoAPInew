using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ICourseBusinessLogic
    {
        public List<Course> GetCourse();
        public int Insertcourse(Course course);

        public int Updatecourse(Course course);

        public int Deletecourse(int id);

        public Course GetBycourseId(int id);


    }
}
