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
    public class YearSemesterBusinessLogic : IYearSemesterBusinessLogic
    {
        IRepoYearSemester yearsemester;
        ICyearRepo CyearRepo;
        IRepoSemester ireposemester;

        public YearSemesterBusinessLogic(IRepoYearSemester Repo, ICyearRepo CyearRepo, IRepoSemester ireposemester)
        {
            yearsemester = Repo;
            this.CyearRepo = CyearRepo;
            this.ireposemester = ireposemester;
        }

        public int DeleteYearSemester(int id)
        {
            return yearsemester.DeleteYearSemester(id);
        }

        public YearSemester GetByYearSemesterId(int id)
        {
            return yearsemester.GetByYearSemesterId(id);
        }

        public List<YearSemester> GetYearSemester()
        {
            return yearsemester.GetYearSemester();
        }

        public int InsertYearSemester(YearSemester yearSemester)
        {
            return yearsemester.InsertYearSemester(yearSemester);
        }

        public int UpdateYearSemester(YearSemester yearSemester)
        {
            return yearsemester.UpdateYearSemester(yearSemester);
        }

        public List<YearsemisemisterList> GetyearsemisemisterLists()
        {

            var yearsemesters = yearsemester.GetYearSemester();
            var Cyear = CyearRepo.GetCyears();
            var semester = ireposemester.GetSemester();

            var data = from y in yearsemesters
                       join
                       C in Cyear on
                       y.CyearsId equals C.Id
                       join
                       sem in semester on
                       y.SemesterId equals sem.Id

                       select new YearsemisemisterList
                       {
                           Id = y.Id,
                           Name = C.Name,
                           SemesterName = sem.Name,
                           OrderId = y.OrderId
                       };
            return data.ToList();

        }
    }
}
