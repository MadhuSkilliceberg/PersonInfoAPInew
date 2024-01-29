using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ITaskDocumentBusinessLogic
    {
        public List<TaskDocument> GetTaskDocuments();
        public int InsertTaskDocument(TaskDocument TaskDocument);

        public bool UpdateTaskDocument(TaskDocument TaskDocument);

        public int DeleteTaskDocument(int id);

        public TaskDocument GetByTaskDocumentId(int id);

    }
}
