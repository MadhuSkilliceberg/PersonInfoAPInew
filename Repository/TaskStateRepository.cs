using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class TaskStateRepository : ITaskStateRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteTaskState(int id)
        {
            var a = person.TaskStates.Where(c => c.Id == id).FirstOrDefault();
            person.TaskStates.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public TaskState GetByTaskStateId(int id)
        {
            return person.TaskStates.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<TaskState> GetTaskStates()
        {
            return person.TaskStates.ToList();
        }

        public int InsertTaskState(TaskState TaskState)
        {
            person.TaskStates.Add(TaskState);
            person.SaveChanges();
            return TaskState.Id;

        }

        public bool UpdateTaskState(TaskState TaskState)
        {
            person.TaskStates.Update(TaskState);
            person.SaveChanges();
            return true;
        }
    }
}
