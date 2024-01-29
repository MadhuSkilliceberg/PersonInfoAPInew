using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class TaskStateBusinessLogic: ITaskStateBusinessLogic
    {
        ITaskStateRepo TaskStateRepo;

        public  TaskStateBusinessLogic(ITaskStateRepo Repo)
        {
            TaskStateRepo = Repo;
        }

        public int DeleteTaskState(int id)
        {
            return TaskStateRepo.DeleteTaskState(id);
        }

        public TaskState GetByTaskStateId(int id)
        {
            return TaskStateRepo.GetByTaskStateId(id);
        }

        public List<TaskState> GetTaskStates()
        {
            return TaskStateRepo.GetTaskStates();
        }

        public int InsertTaskState(TaskState TaskState)
        {
            return TaskStateRepo.InsertTaskState(TaskState);
        }

        public bool UpdateTaskState(TaskState TaskState)
        {
            return TaskStateRepo.UpdateTaskState(TaskState);
        }
    }
}
