using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class TaskDocumentBusinessLogic: ITaskDocumentBusinessLogic
    {
        ITaskDocumentRepo TaskDocumentRepo;

        public  TaskDocumentBusinessLogic(ITaskDocumentRepo Repo)
        {
            TaskDocumentRepo = Repo;
        }

        public int DeleteTaskDocument(int id)
        {
            return TaskDocumentRepo.DeleteTaskDocument(id);
        }

        public TaskDocument GetByTaskDocumentId(int id)
        {
            return TaskDocumentRepo.GetByTaskDocumentId(id);
        }

        public List<TaskDocument> GetTaskDocuments()
        {
            return TaskDocumentRepo.GetTaskDocuments();
        }

        public int InsertTaskDocument(TaskDocument TaskDocument)
        {
            return TaskDocumentRepo.InsertTaskDocument(TaskDocument);
        }

        public bool UpdateTaskDocument(TaskDocument TaskDocument)
        {
            return TaskDocumentRepo.UpdateTaskDocument(TaskDocument);
        }
    }
}
