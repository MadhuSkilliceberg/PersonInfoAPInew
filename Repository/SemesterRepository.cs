using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class SemesterRepository : IRepoSemester
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteSemester(int id)
        {
            var a = person.Semesters.Where(c => c.Id == id).FirstOrDefault();
            person.Semesters.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Semester GetBySemesterId(int id)
        {
            return person.Semesters.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Semester> GetSemester()
        {
            return person.Semesters.ToList();
        }

        public int InsertSemester(Semester semester)
        {
            person.Semesters.Add(semester);
            person.SaveChanges();
            return semester.Id;

        }

        public int UpdateSemester(Semester semester)
        {
            person.Semesters.Update(semester);
            person.SaveChanges();
            return semester.Id;
                ;
        }
    }
}
