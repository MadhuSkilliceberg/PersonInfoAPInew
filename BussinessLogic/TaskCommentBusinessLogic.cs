using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class TaskCommentBusinessLogic: ITaskCommentBusinessLogic
    {
        ITaskCommentRepo TaskCommentRepo;

        public  TaskCommentBusinessLogic(ITaskCommentRepo Repo)
        {
            TaskCommentRepo = Repo;
        }

        public int DeleteTaskComment(int id)
        {
            return TaskCommentRepo.DeleteTaskComment(id);
        }

        public TaskComment GetByTaskCommentId(int id)
        {
            return TaskCommentRepo.GetByTaskCommentId(id);
        }

        public List<TaskComment> GetTaskComments()
        {
            return TaskCommentRepo.GetTaskComments();
        }

        public int InsertTaskComment(TaskComment TaskComment)
        {
            return TaskCommentRepo.InsertTaskComment(TaskComment);
        }

        public bool UpdateTaskComment(TaskComment TaskComment)
        {
            return TaskCommentRepo.UpdateTaskComment(TaskComment);
        }
    }
}
