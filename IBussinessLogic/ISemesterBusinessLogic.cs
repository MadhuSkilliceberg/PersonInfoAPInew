using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ISemesterBusinessLogic
    {
        public List<Semester> GetSemester();
        public int InsertSemester(Semester semester);

        public int UpdateSemester(Semester semester);

        public int DeleteSemester(int id);

        public Semester GetBySemesterId(int id);

    }
}
