using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ICourseYearRepo
    {
        public List<CourseYear> GetCourseYears();
        public int InsertCourseYear(CourseYear courseYear);

        public int UpdateCourseYear(CourseYear courseYear);

        public int DeleteCourseYear(int id);

        public CourseYear GetByCourseYearId(int id);


    }
}
