using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class CourseYearRepository : ICourseYearRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteCourseYear(int id)
        {
            var data = person.CourseYears.Where(c => c.Id == id).FirstOrDefault();
            person.CourseYears.Remove(data);
            person.SaveChanges();
            return 1;
        }

        public CourseYear GetByCourseYearId(int id)
        {
            return person.CourseYears.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<CourseYear> GetCourseYears()
        {
            return person.CourseYears.ToList();
        }

        public int InsertCourseYear(CourseYear courseYear)
        {
            person.CourseYears.Add(courseYear);
            person.SaveChanges();
            return courseYear.Id;

        }

        public int UpdateCourseYear(CourseYear courseYear)
        {
            person.CourseYears.Update(courseYear);
            person.SaveChanges();
            return courseYear.Id;
        }
    }
}
