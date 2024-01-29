using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class SprintTaskRepository : ISprintTaskRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteSprintTask(int id)
        {
            var a = person.SprintTasks.Where(c => c.Id == id).FirstOrDefault();
            person.SprintTasks.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public SprintTask GetBySprintTaskId(int id)
        {
            return person.SprintTasks.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<SprintTask> GetSprintTasks()
        {
            return person.SprintTasks.ToList();
        }

        public int InsertSprintTask(SprintTask SprintTask)
        {
            person.SprintTasks.Add(SprintTask);
            person.SaveChanges();
            return SprintTask.Id;

        }

        public bool UpdateSprintTask(SprintTask SprintTask)
        {
            person.SprintTasks.Update(SprintTask);
            person.SaveChanges();
            return true;
        }
    }
}
