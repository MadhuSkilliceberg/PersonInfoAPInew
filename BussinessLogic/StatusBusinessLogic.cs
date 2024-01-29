using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class StatusBusinessLogic: IStatusBusinessLogic
    {
        IStatusRepo StatusRepo;

        public  StatusBusinessLogic(IStatusRepo Repo)
        {
            StatusRepo = Repo;
        }

        public int DeleteStatus(int id)
        {
            return StatusRepo.DeleteStatus(id);
        }

        public Status GetByStatusId(int id)
        {
            return StatusRepo.GetByStatusId(id);
        }

        public List<Status> GetStatuss()
        {
            return StatusRepo.GetStatuss();
        }

        public int InsertStatus(Status Status)
        {
            return StatusRepo.InsertStatus(Status);
        }

        public bool UpdateStatus(Status Status)
        {
            return StatusRepo.UpdateStatus(Status);
        }
    }
}
