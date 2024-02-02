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
   // [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionCourseController : ControllerBase
    {
     private readonly   IInstitutionCourseBusinessLogic _institutionCourseBusiness;

        public InstitutionCourseController(IInstitutionCourseBusinessLogic institutionCourseBusiness)
        {
            _institutionCourseBusiness = institutionCourseBusiness;
        }



        [Route("DeleteInstitutionCourseByInstitutionCourseId/{institutionCourseId}")]
        [HttpDelete]
        public async Task<int> DeleteInstitutionCourseByInstitutionCourseId(int institutionCourseId)

        {
            return await _institutionCourseBusiness.DeleteInstitutionCourseByInstitutionCourseId(institutionCourseId);
        }




        [Route("GetInstitutionCourseByInstitutionCourseId/{institutionCourseId}")]
        [HttpGet]
        public async Task<InstitutionCourse> GetInstitutionCourseByInstitutionCourseId(int institutionCourseId)

        {
            return await _institutionCourseBusiness.GetInstitutionCourseByInstitutionCourseId(institutionCourseId);
        }




        [Route("GEtInstitutionCourses")]
        [HttpGet]
        public async Task<List<InstitutionCourse>> GetInstitutionCourse()

        {
            return await _institutionCourseBusiness.GetInstitutionCourse();
        }




        [Route("AddInstitutionCourses")]
        [HttpPost]
        public async Task<int> AddInstitutionCourse(InstitutionCourse institutionCourse)

        {
            return await _institutionCourseBusiness.AddInstitutionCourse(institutionCourse);
        }




        [Route("UpdateInstitutionCourse")]
        [HttpPut]
        public async Task<int> UpdateInstitutionCourse(InstitutionCourse institutionCourse)

        {
            return await _institutionCourseBusiness.UpdateInstitutionCourse(institutionCourse);
        }


        [Route("GetinstitutionCourseLists")]
        [HttpGet]
        public async Task<List<InstitutionCourseList>> GetinstitutionCourseLists()
        { 

            return await _institutionCourseBusiness.GetinstitutionCourseLists();
        }

        [Route("DeleteRangeInstitutionCourseDetails")]
        [HttpDelete]
        public async Task<bool> DeleteRangeInstitutionCourseDetails(List<InstitutionCourse> institutionCourses)

        {
            return await _institutionCourseBusiness.DeleteRangeInstitutionCourseDetails(institutionCourses);
        }


        [Route("AddRangeInstitutionCourseDetails")]
        [HttpPost]
        public async Task<bool> AddRangeInstitutionCourseDetails(List<InstitutionCourse> institutionCourses)
        {
            return await _institutionCourseBusiness.AddRangeInstitutionCourseDetails(institutionCourses);
        }


        [Route("UpdateRangeInstitutionCourse")]
        [HttpPut]
        public async Task<int> UpdateRangeInstitutionCourse(List<InstitutionCourse> institutionCourse)

        {
            return await _institutionCourseBusiness.UpdateRangeInstitutionCourse(institutionCourse);
        }


    }
}
