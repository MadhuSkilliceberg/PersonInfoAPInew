using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class JobBusinessLogic: IJobBusinessLogic
    {
        IJobRepo JobRepo;

        public  JobBusinessLogic(IJobRepo Repo)
        {
            JobRepo = Repo;
        }

        public int DeleteJob(int id)
        {
            return JobRepo.DeleteJob(id);
        }

        public Job GetByJobId(int id)
        {
            return JobRepo.GetByJobId(id);
        }

        public List<Job> GetJobs()
        {
            return JobRepo.GetJobs();
        }

        public List<Skill> GetLookUpSearch(string name)
        {
            throw new NotImplementedException();
        }

        public int InsertJob(Job Job)
        {
            return JobRepo.InsertJob(Job);
        }

        public bool UpdateJob(Job Job)
        {
            return JobRepo.UpdateJob(Job);
        }
    }
}
