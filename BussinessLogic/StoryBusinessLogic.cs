using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Story = PersonsInfoV2Api.Entities.Task;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class StoryBusinessLogic: IStoryBusinessLogic
    {
        IStoryRepo StoryRepo;

        public  StoryBusinessLogic(IStoryRepo Repo)
        {
            StoryRepo = Repo;
        }

        public int DeleteStory(int id)
        {
            return StoryRepo.DeleteStory(id);
        }

        public Story GetByStoryId(int id)
        {
            return StoryRepo.GetByStoryId(id);
        }

        public List<Story> GetStory()
        {
            return StoryRepo.GetStorys();
        }

        public int InsertStory(Story story)
        {
            return StoryRepo.InsertStory(story);
        }

        public int UpdateStory(Story story)
        {
            return StoryRepo.UpdateStory(story);
        }

      
    }
}
