using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class SprintBusinessLogic: ISprintBusinessLogic
    {
        ISprintRepo SprintRepo;

        public  SprintBusinessLogic(ISprintRepo Repo)
        {
            SprintRepo = Repo;
        }

        public int DeleteSprint(int id)
        {
            return SprintRepo.DeleteSprint(id);
        }

        public Sprint GetBySprintId(int id)
        {
            return SprintRepo.GetBySprintId(id);
        }

        public List<Sprint> GetSprints()
        {
            return SprintRepo.GetSprints();
        }

        public int InsertSprint(Sprint Sprint)
        {
            return SprintRepo.InsertSprint(Sprint);
        }

        public bool UpdateSprint(Sprint Sprint)
        {
            return SprintRepo.UpdateSprint(Sprint);
        }
    }
}
