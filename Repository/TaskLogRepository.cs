using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class TaskLogRepository : ITaskLogRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteTaskLog(int id)
        {
            var a = person.TaskLogs.Where(c => c.Id == id).FirstOrDefault();
            person.TaskLogs.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public TaskLog GetByTaskLogId(int id)
        {
            return person.TaskLogs.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<TaskLog> GetTaskLogs()
        {
            return person.TaskLogs.ToList();
        }

        public int InsertTaskLog(TaskLog TaskLog)
        {
            person.TaskLogs.Add(TaskLog);
            person.SaveChanges();
            return TaskLog.Id;

        }

        public bool UpdateTaskLog(TaskLog TaskLog)
        {
            person.TaskLogs.Update(TaskLog);
            person.SaveChanges();
            return true;
        }
    }
}
