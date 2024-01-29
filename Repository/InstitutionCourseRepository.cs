using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionCourseRepository : IRepoInstitutionCourse
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteInstitutionCourse(int id)
        {
            var a = person.InstitutionCourses.Where(c => c.Id == id).FirstOrDefault();
            person.InstitutionCourses.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public InstitutionCourse GetByInstitutionCourseId(int id)
        {
            return person.InstitutionCourses.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<InstitutionCourse> GetInstitutionCourse()
        {
            return person.InstitutionCourses.ToList();
        }

        public int InsertInstitutionCourse(InstitutionCourse institutionCourse)
        {
            person.InstitutionCourses.Add(institutionCourse);
            person.SaveChanges();
            return institutionCourse.Id;

        }

        public int UpdateInstitutionCourse(InstitutionCourse institutionCourse)
        {
            person.InstitutionCourses.Update(institutionCourse);
            person.SaveChanges();
            return institutionCourse.Id;
        }

        public bool institutionCourseDetails(List<InstitutionCourse> institutionCourses)
        {
            try
            {
                if (institutionCourses != null)
                {
                    person.InstitutionCourses.AddRange(institutionCourses);
                    if(person != null)
                    {
                        person.SaveChanges();
                    }
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
