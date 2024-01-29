using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CourseBusinessLogic : ICourseBusinessLogic
    {
        ICourseRepo  courseRepo;

        public CourseBusinessLogic(ICourseRepo courseRepo)
        {
            this.courseRepo = courseRepo;
        }

        public int Deletecourse(int id)
        {
            return courseRepo.Deletecourse(id);
        }

        public Course GetBycourseId(int id)
        {
            return courseRepo.GetBycourseId(id);
        }

        public List<Course> GetCourse()
        {
            return courseRepo.GetCourse();
        }

        public int Insertcourse(Course course)
        {
            return courseRepo.Insertcourse(course);
        }

        public int Updatecourse(Course course)
        {
            return courseRepo.Updatecourse(course);
        }
    }
}

