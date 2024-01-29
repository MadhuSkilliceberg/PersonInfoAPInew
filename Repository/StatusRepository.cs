using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class StatusRepository : IStatusRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteStatus(int id)
        {
            var a = person.Statuses.Where(c => c.Id == id).FirstOrDefault();
            person.Statuses.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Status GetByStatusId(int id)
        {
            return person.Statuses.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Status> GetStatuss()
        {
            return person.Statuses.ToList();
        }

        public int InsertStatus(Status Status)
        {
            person.Statuses.Add(Status);
            person.SaveChanges();
            return Status.Id;

        }

        public bool UpdateStatus(Status Status)
        {
            person.Statuses.Update(Status);
            person.SaveChanges();
            return true;
        }
    }
}
