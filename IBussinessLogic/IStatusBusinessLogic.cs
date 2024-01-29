using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IStatusBusinessLogic
    {
        public List<Status> GetStatuss();
        public int InsertStatus(Status Status);

        public bool UpdateStatus(Status Status);

        public int DeleteStatus(int id);

        public Status GetByStatusId(int id);

    }
}
