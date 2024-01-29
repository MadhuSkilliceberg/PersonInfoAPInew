using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class TaskLogBusinessLogic: ITaskLogBusinessLogic
    {
        ITaskLogRepo TaskLogRepo;

        public  TaskLogBusinessLogic(ITaskLogRepo Repo)
        {
            TaskLogRepo = Repo;
        }

        public int DeleteTaskLog(int id)
        {
            return TaskLogRepo.DeleteTaskLog(id);
        }

        public TaskLog GetByTaskLogId(int id)
        {
            return TaskLogRepo.GetByTaskLogId(id);
        }

        public List<TaskLog> GetTaskLogs()
        {
            return TaskLogRepo.GetTaskLogs();
        }

        public int InsertTaskLog(TaskLog TaskLog)
        {
            return TaskLogRepo.InsertTaskLog(TaskLog);
        }

        public bool UpdateTaskLog(TaskLog TaskLog)
        {
            return TaskLogRepo.UpdateTaskLog(TaskLog);
        }
    }
}
