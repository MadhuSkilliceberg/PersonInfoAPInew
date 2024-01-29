using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IRepoSemester
    {
        public List<Semester> GetSemester();
        public int InsertSemester(Semester Semester);

        public int UpdateSemester(Semester Semester);

        public int DeleteSemester(int id);

        public Semester GetBySemesterId(int id);


    }
}
