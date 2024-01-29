using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Story = PersonsInfoV2Api.Entities.Task;


namespace PersonsInfoV2Api.Repository
{
    public class StoryRepository : IStoryRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteStory(int id)
        {
            var a = person.Tasks.Where(c => c.Id == id).FirstOrDefault();
            person.Tasks.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Story GetByStoryId(int id)
        {
            return person.Tasks.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Story> GetStorys()
        {
            return person.Tasks.ToList();
        }

        public int InsertStory(Story story)
        {
            person.Tasks.Add(story);
            person.SaveChanges();
            return story.Id;

        }

        public int UpdateStory(Story story)
        {
            person.Tasks.Update(story);
            person.SaveChanges();
            return story.Id;
        }
    }
}
