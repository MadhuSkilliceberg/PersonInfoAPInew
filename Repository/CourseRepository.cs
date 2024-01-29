using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class CourseRepoRepository : ICourseRepo
    {
        private readonly PersonsInfoV3NewContext person=new PersonsInfoV3NewContext();

        // PersonsInfoV3NewContext person;
        //public CourseRepoRepository(PersonsInfoV3NewContext  personsInfo1Context)
        //{
        //    this.person = personsInfo1Context;
        //    //person = personsInfo1Context;
        //}
        public int Deletecourse(int id)
        {
            var a = person.Courses.Where(c => c.Id == id).FirstOrDefault();
            person.Courses.Remove(a);
            person.SaveChanges();
            return 1;
        }

           public Course GetBycourseId(int id)
        {
            return person.Courses.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Course> GetCourse()
        {
            try
            {
                return person.Courses.ToList();
            }catch(Exception ex)
            {
                return new List<Course>();
            }
        }

        public int Insertcourse(Course course)
        {
            person.Courses.Add(course);
            person.SaveChanges();
            return course.Id;

        }

        public int Updatecourse(Course course)
        {
            person.Courses.Update(course);
            person.SaveChanges();
            return course.Id;
        }
    }
}
