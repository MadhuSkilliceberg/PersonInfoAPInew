using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class SemesterBusinessLogic: ISemesterBusinessLogic
    {
        IRepoSemester ireposemester;

        public SemesterBusinessLogic(IRepoSemester Repo)
        {
            ireposemester = Repo;
        }

        public int DeleteSemester(int id)
        {
            return ireposemester.DeleteSemester(id);
        }

        public Semester GetBySemesterId(int id)
        {
            return ireposemester.GetBySemesterId(id);
        }

        public List<Semester> GetSemester()
        {
            return ireposemester.GetSemester();
        }

        public int InsertSemester(Semester semester)
        {
            return ireposemester.InsertSemester(semester);
        }

        public int UpdateSemester(Semester semester)
        {
            return ireposemester.UpdateSemester(semester);
        }
    }
}
