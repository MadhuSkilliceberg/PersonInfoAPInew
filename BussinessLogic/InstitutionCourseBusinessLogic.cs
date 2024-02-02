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
    public class InstitutionCourseBusinessLogic : IInstitutionCourseBusinessLogic
    {
        private readonly IInstitutionCourseRepository _institutionCourseRepository;
        private readonly ICourseRepo _courseRepo;
        private readonly IInstitutionRepository _institutionRepository;

        public InstitutionCourseBusinessLogic(IInstitutionCourseRepository institutionCourseRepository, ICourseRepo courseRepo, IInstitutionRepository institutionRepository)
        {
            _institutionCourseRepository = institutionCourseRepository;
            _courseRepo = courseRepo;
            _institutionRepository = institutionRepository;
        }

        public async Task<int> DeleteInstitutionCourseByInstitutionCourseId(int institutionCourseId)

        {
            return await _institutionCourseRepository.DeleteInstitutionCourseByInstitutionCourseId(institutionCourseId);
        }

        public async Task<InstitutionCourse> GetInstitutionCourseByInstitutionCourseId(int institutionCourseId)

        {
            return await _institutionCourseRepository.GetInstitutionCourseByInstitutionCourseId(institutionCourseId);
        }

        public async Task<List<InstitutionCourse>> GetInstitutionCourse()

        {
            return await _institutionCourseRepository.GetInstitutionCourse();
        }

        public async Task<int> AddInstitutionCourse(InstitutionCourse institutionCourse)

        {
            return await _institutionCourseRepository.AddInstitutionCourse(institutionCourse);
        }

        public async Task<int> UpdateInstitutionCourse(InstitutionCourse institutionCourse)

        {
            return await _institutionCourseRepository.UpdateInstitutionCourse(institutionCourse);
        }

        public async Task<List<InstitutionCourseList>> GetinstitutionCourseLists()
        {
            var institutionCourses = await _institutionCourseRepository.GetInstitutionCourse();
            var course = _courseRepo.GetCourse();
            var user = await _institutionRepository.GetInstitutions();

            var data = from i in institutionCourses
                       join
                       c in course on
                       i.InstitutionId equals c.Id
                       join
                       INS in user on
                       i.CourseId equals INS.Id

                       select new InstitutionCourseList
                       {
                           Id = i.Id,
                           Name = i.Name,
                           InstitutionName = i.Name,
                           CourseName = i.Name,
                           IsActive = i.IsActive
                       };
            return data.ToList();
        }


        public async Task<int> UpdateRangeInstitutionCourse(List<InstitutionCourse> institutionCourse)
        {
            return await _institutionCourseRepository.UpdateRangeInstitutionCourse(institutionCourse);
        }
        public async Task<bool> AddRangeInstitutionCourseDetails(List<InstitutionCourse> institutionCourses)
        {
            return await _institutionCourseRepository.AddRangeInstitutionCourseDetails(institutionCourses);
        }


        public async Task<bool> DeleteRangeInstitutionCourseDetails(List<InstitutionCourse> institutionCourses)

        {
            return await _institutionCourseRepository.DeleteRangeInstitutionCourseDetails(institutionCourses);
        }

    }
}
