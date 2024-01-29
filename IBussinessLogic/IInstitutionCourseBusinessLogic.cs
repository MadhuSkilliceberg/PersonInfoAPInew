using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IInstitutionCourseBusinessLogic
    {
        public List<InstitutionCourse> GetInstitutionCourse();
        public int InsertInstitutionCourse(InstitutionCourse institutionCourse);

        public int UpdateInstitutionCourse(InstitutionCourse institutionCourse);

        public int DeleteInstitutionCourse(int id);

        public InstitutionCourse GetByInstitutionCourseId(int id);

        public List<InstitutionCourseList> GetinstitutionCourseLists();
        

    }
}
