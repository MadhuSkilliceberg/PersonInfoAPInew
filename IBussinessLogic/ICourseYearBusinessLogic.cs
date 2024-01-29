using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ICourseYearBusinessLogic
    {
        public List<CourseYear> GetCourseYears();
        public int InsertCourseYear(CourseYear courseYear);

        public int UpdateCourseYear(CourseYear courseYear);

        public int DeleteCourseYear(int id);

        public CourseYear GetByCourseYearId(int id);

        public List<CouresYearList> GetcouresYearLists();
    }
}
