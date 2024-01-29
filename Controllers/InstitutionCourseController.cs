using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionCourseController : ControllerBase
    {
        IInstitutionCourseBusinessLogic institutionCourseBusiness;

        public InstitutionCourseController(IInstitutionCourseBusinessLogic logic)
        {
            institutionCourseBusiness = logic;
        }



        [Route("DeleteInstitutionCourses/{Id}")]
        [HttpDelete]
        public int DeleteInstitutionCourse(int id)
        {
            return institutionCourseBusiness.DeleteInstitutionCourse(id);
        }




        [Route("GetInstitutionCoursesById/{Id}")]
        [HttpGet]
        public InstitutionCourse GetByInstitutionCourseId(int id)
        {
            return institutionCourseBusiness.GetByInstitutionCourseId(id);
        }




        [Route("GEtInstitutionCourses")]
        [HttpGet]
        public List<InstitutionCourse> GetInstitutionCourse()
        {
            return institutionCourseBusiness.GetInstitutionCourse();
        }




        [Route("AddInstitutionCourses")]
        [HttpPost]
        public int InsertInstitutionCourse(InstitutionCourse institutionCourse)
        {
            return institutionCourseBusiness.InsertInstitutionCourse(institutionCourse);
        }




        [Route("UpdateInstitutionCourses")]
        [HttpPut]
        public int UpdateInstitutionCourse(InstitutionCourse institutionCourse)
        {
            return institutionCourseBusiness.UpdateInstitutionCourse(institutionCourse);
        }


        [Route("GetinstitutionCourseLists")]
        [HttpGet]
        public List<InstitutionCourseList> GetinstitutionCourseLists()
        {
            return institutionCourseBusiness.GetinstitutionCourseLists();
        }
    }
}
