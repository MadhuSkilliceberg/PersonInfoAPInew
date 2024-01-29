using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class TaskCommentDocumentRepository : ITaskCommentDocumentRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteTaskCommentDocument(int id)
        {
            var a = person.TaskCommentDocuments.Where(c => c.Id == id).FirstOrDefault();
            person.TaskCommentDocuments.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public TaskCommentDocument GetByTaskCommentDocumentId(int id)
        {
            return person.TaskCommentDocuments.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<TaskCommentDocument> GetTaskCommentDocuments()
        {
            return person.TaskCommentDocuments.ToList();
        }

        public int InsertTaskCommentDocument(TaskCommentDocument TaskCommentDocument)
        {
            person.TaskCommentDocuments.Add(TaskCommentDocument);
            person.SaveChanges();
            return TaskCommentDocument.Id;

        }

        public bool UpdateTaskCommentDocument(TaskCommentDocument TaskCommentDocument)
        {
            person.TaskCommentDocuments.Update(TaskCommentDocument);
            person.SaveChanges();
            return true;
        }
    }
}
