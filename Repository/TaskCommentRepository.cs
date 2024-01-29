using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class TaskCommentRepository : ITaskCommentRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteTaskComment(int id)
        {
            var a = person.TaskComments.Where(c => c.Id == id).FirstOrDefault();
            person.TaskComments.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public TaskComment GetByTaskCommentId(int id)
        {
            return person.TaskComments.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<TaskComment> GetTaskComments()
        {
            return person.TaskComments.ToList();
        }

        public int InsertTaskComment(TaskComment TaskComment)
        {
            person.TaskComments.Add(TaskComment);
            person.SaveChanges();
            return TaskComment.Id;

        }

        public bool UpdateTaskComment(TaskComment TaskComment)
        {
            person.TaskComments.Update(TaskComment);
            person.SaveChanges();
            return true;
        }
    }
}
