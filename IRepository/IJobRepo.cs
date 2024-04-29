using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IJobRepo
    {
        public List<Job> GetJobs();
        public int InsertJob(Job Job);

        public bool UpdateJob(Job Job);

        public int DeleteJob(int id);

        public Job GetByJobId(int id);


    }
}
