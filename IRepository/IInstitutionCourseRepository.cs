using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IInstitutionCourseRepository
    {
        public Task<List<InstitutionCourse>> GetInstitutionCourse();
        public Task<int> AddInstitutionCourse(InstitutionCourse institutionCourse);

        public Task<int> UpdateRangeInstitutionCourse(List<InstitutionCourse> institutionCourse);


        public Task<int> UpdateInstitutionCourse(InstitutionCourse institutionCourse);

        public Task<int> DeleteInstitutionCourseByInstitutionCourseId(int institutionCourseId);

        public Task<InstitutionCourse> GetInstitutionCourseByInstitutionCourseId(int institutionCourseId);
        public Task<bool> AddRangeInstitutionCourseDetails(List<InstitutionCourse> institutionCourses);

        public Task<bool> DeleteRangeInstitutionCourseDetails(List<InstitutionCourse> institutionCourses);

    }
}
