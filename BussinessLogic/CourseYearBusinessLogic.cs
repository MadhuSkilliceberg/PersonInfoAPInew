using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CourseYearBusinessLogic : ICourseYearBusinessLogic
    {
        ICourseYearRepo courseYearRepo;
        ICourseRepo courseRepo;
        ICyearRepo CyearRepo;


        public CourseYearBusinessLogic(ICourseYearRepo Repo, ICourseRepo courseRepo, ICyearRepo CyearRepo)
        {
            courseYearRepo = Repo;
            this.courseRepo = courseRepo;
            this.CyearRepo = CyearRepo;
        }

        public int DeleteCourseYear(int id)
        {
            return courseYearRepo.DeleteCourseYear(id);
        }

        public CourseYear GetByCourseYearId(int id)
        {
            return courseYearRepo.GetByCourseYearId(id);
        }
        
        public List<CourseYear> GetCourseYears()
        {
            return courseYearRepo.GetCourseYears();
        }

        public int InsertCourseYear(CourseYear courseYear)
        {
            return courseYearRepo.InsertCourseYear(courseYear);
        }

        public int UpdateCourseYear(CourseYear courseYear)
        {
            return courseYearRepo.UpdateCourseYear(courseYear);
        }


        public List<CouresYearList> GetcouresYearLists()
        {

            var CourseYearRepodata = courseYearRepo.GetCourseYears();
            var coursesdata = courseRepo.GetCourse();
            var Cyeardata = CyearRepo.GetCyears();

            var data = from Cy in CourseYearRepodata
                       join
                       c in coursesdata
                       on Cy.CourseId equals c.Id
                       join
                       cyeardata in Cyeardata
                       on Cy.CyearsId equals cyeardata.Id

                       select new CouresYearList
                       {
                           Id = Cy.Id,
                           Name = c.Name,
                           CYName = cyeardata.Name,
                           IsActive = Cy.IsActive,
                           OrderId = Cy.OrderId
                       };
            return data.ToList();

        }
    }
}
