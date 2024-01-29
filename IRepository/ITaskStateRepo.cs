using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ITaskStateRepo
    {
        public List<TaskState> GetTaskStates();
        public int InsertTaskState(TaskState TaskState);

        public bool UpdateTaskState(TaskState TaskState);

        public int DeleteTaskState(int id);

        public TaskState GetByTaskStateId(int id);


    }
}
