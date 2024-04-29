using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class JobRepository : IJobRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteJob(int id)
        {
            var a = person.Jobs.Where(c => c.Id == id).FirstOrDefault();
            person.Jobs.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Job GetByJobId(int id)
        {
            return person.Jobs.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Job> GetJobs()
        {
            return person.Jobs.ToList();
        }

        public int InsertJob(Job Job)
        {
            person.Jobs.Add(Job);
            person.SaveChanges();
            return Job.Id;

        }

        public bool UpdateJob(Job Job)
        {
            person.Jobs.Update(Job);
            person.SaveChanges();
            return true;
        }
    }
}
