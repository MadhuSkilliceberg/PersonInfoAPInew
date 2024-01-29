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
        IRepoInstitutionCourse SkillRepo;
        ICourseRepo courseRepo;
        IInstitutionRepo InstitutionsRepository;

        public InstitutionCourseBusinessLogic(IRepoInstitutionCourse Repo, ICourseRepo courseRepo, IInstitutionRepo userRepository)
        {
            SkillRepo = Repo;
           this. courseRepo = courseRepo;
            this.InstitutionsRepository = userRepository;
        }

        public int DeleteInstitutionCourse(int id)
        {
            return SkillRepo.DeleteInstitutionCourse(id);
        }

        public InstitutionCourse GetByInstitutionCourseId(int id)
        {
            return SkillRepo.GetByInstitutionCourseId(id);
        }

        public List<InstitutionCourse> GetInstitutionCourse()
        {
            return SkillRepo.GetInstitutionCourse();
        }

        public int InsertInstitutionCourse(InstitutionCourse institutionCourse)
        {
            return SkillRepo.InsertInstitutionCourse(institutionCourse);
        }

        public int UpdateInstitutionCourse(InstitutionCourse institutionCourse)
        {
            return SkillRepo.UpdateInstitutionCourse(institutionCourse);
        }

        public List<InstitutionCourseList> GetinstitutionCourseLists()
        {
            var skillrepo = SkillRepo.GetInstitutionCourse();
            var course = courseRepo.GetCourse();
            var user = InstitutionsRepository.GetInstitutions();

            var data = from i in skillrepo
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
    }
}
