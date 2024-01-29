using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ITaskLogRepo
    {
        public List<TaskLog> GetTaskLogs();
        public int InsertTaskLog(TaskLog TaskLog);

        public bool UpdateTaskLog(TaskLog TaskLog);

        public int DeleteTaskLog(int id);

        public TaskLog GetByTaskLogId(int id);


    }
}
