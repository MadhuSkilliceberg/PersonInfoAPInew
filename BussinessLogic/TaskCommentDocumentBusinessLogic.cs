using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class TaskCommentDocumentBusinessLogic: ITaskCommentDocumentBusinessLogic
    {
        ITaskCommentDocumentRepo TaskCommentDocumentRepo;

        public  TaskCommentDocumentBusinessLogic(ITaskCommentDocumentRepo Repo)
        {
            TaskCommentDocumentRepo = Repo;
        }

        public int DeleteTaskCommentDocument(int id)
        {
            return TaskCommentDocumentRepo.DeleteTaskCommentDocument(id);
        }

        public TaskCommentDocument GetByTaskCommentDocumentId(int id)
        {
            return TaskCommentDocumentRepo.GetByTaskCommentDocumentId(id);
        }

        public List<TaskCommentDocument> GetTaskCommentDocuments()
        {
            return TaskCommentDocumentRepo.GetTaskCommentDocuments();
        }

        public int InsertTaskCommentDocument(TaskCommentDocument TaskCommentDocument)
        {
            return TaskCommentDocumentRepo.InsertTaskCommentDocument(TaskCommentDocument);
        }

        public bool UpdateTaskCommentDocument(TaskCommentDocument TaskCommentDocument)
        {
            return TaskCommentDocumentRepo.UpdateTaskCommentDocument(TaskCommentDocument);
        }
    }
}
