using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Story = PersonsInfoV2Api.Entities.Task;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IStoryBusinessLogic
    {
        public List<Story> GetStory();
        public int InsertStory(Story story);

        public int UpdateStory(Story story);

        public int DeleteStory(int id);

        public Story GetByStoryId(int id);

        //public List<YearsemisemisterList> GetyearsemisemisterLists();
    }
}
