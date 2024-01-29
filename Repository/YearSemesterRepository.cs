using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class YearSemesterRepository : IRepoYearSemester
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();

        public int DeleteYearSemester(int id)
        {
            var a = person.YearSemesters.Where(c => c.Id == id).FirstOrDefault();
            person.YearSemesters.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public YearSemester GetByYearSemesterId(int id)
        {
            return person.YearSemesters.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<YearSemester> GetYearSemester()
        {
            return person.YearSemesters.ToList();
        }

        public int InsertYearSemester(YearSemester yearSemester)
        {
            person.YearSemesters.Add(yearSemester);
            person.SaveChanges();
            return yearSemester.Id;

        }

        public int UpdateYearSemester(YearSemester yearSemester)
        {
            person.YearSemesters.Update(yearSemester);
            person.SaveChanges();
            return yearSemester.Id;
        }
    }
}
