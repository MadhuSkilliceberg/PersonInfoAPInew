using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class SprintTaskBusinessLogic: ISprintTaskBusinessLogic
    {
        ISprintTaskRepo SprintTaskRepo;

        public  SprintTaskBusinessLogic(ISprintTaskRepo Repo)
        {
            SprintTaskRepo = Repo;
        }

        public int DeleteSprintTask(int id)
        {
            return SprintTaskRepo.DeleteSprintTask(id);
        }

        public SprintTask GetBySprintTaskId(int id)
        {
            return SprintTaskRepo.GetBySprintTaskId(id);
        }

        public List<SprintTask> GetSprintTasks()
        {
            return SprintTaskRepo.GetSprintTasks();
        }

        public int InsertSprintTask(SprintTask SprintTask)
        {
            return SprintTaskRepo.InsertSprintTask(SprintTask);
        }

        public bool UpdateSprintTask(SprintTask SprintTask)
        {
            return SprintTaskRepo.UpdateSprintTask(SprintTask);
        }
    }
}
