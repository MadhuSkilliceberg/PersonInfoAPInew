using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Story = PersonsInfoV2Api.Entities.Task;
using Microsoft.AspNetCore.Authorization;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        IStoryBusinessLogic StoryBusinessLogic;

        public StoryController(IStoryBusinessLogic Repo)
        {
            StoryBusinessLogic =Repo;
        }
        [Route("DeleteTask/{id}")]
        [HttpDelete]
        public int DeleteStory(int id)
        {
            return StoryBusinessLogic.DeleteStory(id);
        }


        [Route("GetTaskById/{id}")]
        [HttpGet]
        public Story GetByStoryId(int id)
        {
            return StoryBusinessLogic.GetByStoryId(id);
        }


        [Route("GetTask")]
        [HttpGet]
        public List<Story> GetStorys()
        {
            return StoryBusinessLogic.GetStory();
        }


        [Route("AddTask")]
        [HttpPost]
        public int InsertStory(Story Story)
        {
            return StoryBusinessLogic.InsertStory(Story);
        }


        [Route("UpdateTask")]
        [HttpPut]
        public int UpdateStory(Story Story)
        {
           
          return StoryBusinessLogic.UpdateStory(Story);
           
        }
}}
