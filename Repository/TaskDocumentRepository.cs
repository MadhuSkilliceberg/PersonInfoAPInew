using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class TaskDocumentRepository : ITaskDocumentRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteTaskDocument(int id)
        {
            var a = person.TaskDocuments.Where(c => c.Id == id).FirstOrDefault();
            person.TaskDocuments.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public TaskDocument GetByTaskDocumentId(int id)
        {
            return person.TaskDocuments.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<TaskDocument> GetTaskDocuments()
        {
            return person.TaskDocuments.ToList();
        }

        public int InsertTaskDocument(TaskDocument TaskDocument)
        {
            person.TaskDocuments.Add(TaskDocument);
            person.SaveChanges();
            return TaskDocument.Id;

        }

        public bool UpdateTaskDocument(TaskDocument TaskDocument)
        {
            person.TaskDocuments.Update(TaskDocument);
            person.SaveChanges();
            return true;
        }
    }
}
