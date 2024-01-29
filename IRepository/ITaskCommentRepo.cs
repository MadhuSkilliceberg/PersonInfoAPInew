using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ITaskCommentRepo
    {
        public List<TaskComment> GetTaskComments();
        public int InsertTaskComment(TaskComment TaskComment);

        public bool UpdateTaskComment(TaskComment TaskComment);

        public int DeleteTaskComment(int id);

        public TaskComment GetByTaskCommentId(int id);


    }
}
