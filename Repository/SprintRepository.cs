using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class SprintRepository : ISprintRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteSprint(int id)
        {
            var a = person.Sprints.Where(c => c.Id == id).FirstOrDefault();
            person.Sprints.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Sprint GetBySprintId(int id)
        {
            return person.Sprints.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Sprint> GetSprints()
        {
            return person.Sprints.ToList();
        }

        public int InsertSprint(Sprint Sprint)
        {
            person.Sprints.Add(Sprint);
            person.SaveChanges();
            return Sprint.Id;

        }

        public bool UpdateSprint(Sprint Sprint)
        {
            person.Sprints.Update(Sprint);
            person.SaveChanges();
            return true;
        }
    }
}
