using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ISprintTaskBusinessLogic
    {
        public List<SprintTask> GetSprintTasks();
        public int InsertSprintTask(SprintTask SprintTask);

        public bool UpdateSprintTask(SprintTask SprintTask);

        public int DeleteSprintTask(int id);

        public SprintTask GetBySprintTaskId(int id);

    }
}
