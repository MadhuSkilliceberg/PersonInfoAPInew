using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class SprintTaskController : ControllerBase
    {
        ISprintTaskBusinessLogic SprintTaskBusinessLogic;

        public SprintTaskController(ISprintTaskBusinessLogic Repo)
        {
            SprintTaskBusinessLogic =Repo;
        }
        [Route("DeleteSprintTask/{Id}")]
        [HttpDelete]
        public int DeleteSprintTask(int id)
        {
            return SprintTaskBusinessLogic.DeleteSprintTask(id);
        }


        [Route("GetSprintTaskById/{Id}")]
        [HttpGet]
        public SprintTask GetBySprintTaskId(int id)
        {
            return SprintTaskBusinessLogic.GetBySprintTaskId(id);
        }


        [Route("GetSprintTasks")]
        [HttpGet]
        public List<SprintTask> GetSprintTasks()
        {
            return SprintTaskBusinessLogic.GetSprintTasks();
        }


        [Route("AddSprintTask")]
        [HttpPost]
        public int InsertSprintTask(SprintTask SprintTask)
        {
            return SprintTaskBusinessLogic.InsertSprintTask(SprintTask);
        }


        [Route("UpdateSprintTask")]
        [HttpPut]
        public bool UpdateSprintTask(SprintTask SprintTask)
        {
           
                return SprintTaskBusinessLogic.UpdateSprintTask(SprintTask);
           
        }
}}
