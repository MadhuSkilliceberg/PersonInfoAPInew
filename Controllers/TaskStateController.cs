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
    public class TaskStateController : ControllerBase
    {
        ITaskStateBusinessLogic TaskStateBusinessLogic;

        public TaskStateController(ITaskStateBusinessLogic Repo)
        {
            TaskStateBusinessLogic =Repo;
        }
        [Route("DeleteTaskState/{id}")]
        [HttpDelete]
        public int DeleteTaskState(int id)
        {
            return TaskStateBusinessLogic.DeleteTaskState(id);
        }


        [Route("GetTaskStateById/{id}")]
        [HttpGet]
        public TaskState GetByTaskStateId(int id)
        {
            return TaskStateBusinessLogic.GetByTaskStateId(id);
        }


        [Route("GetTaskState")]
        [HttpGet]
        public List<TaskState> GetTaskStates()
        {
            return TaskStateBusinessLogic.GetTaskStates();
        }


        [Route("AddTaskState")]
        [HttpPost]
        public int InsertTaskState(TaskState TaskState)
        {
            return TaskStateBusinessLogic.InsertTaskState(TaskState);
        }


        [Route("UpdateTaskState")]
        [HttpPut]
        public bool UpdateTaskState(TaskState TaskState)
        {
           
                return TaskStateBusinessLogic.UpdateTaskState(TaskState);
           
        }
}}
