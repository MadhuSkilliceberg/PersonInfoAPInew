using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ITaskCommentDocumentBusinessLogic
    {
        public List<TaskCommentDocument> GetTaskCommentDocuments();
        public int InsertTaskCommentDocument(TaskCommentDocument TaskCommentDocument);

        public bool UpdateTaskCommentDocument(TaskCommentDocument TaskCommentDocument);

        public int DeleteTaskCommentDocument(int id);

        public TaskCommentDocument GetByTaskCommentDocumentId(int id);

    }
}
