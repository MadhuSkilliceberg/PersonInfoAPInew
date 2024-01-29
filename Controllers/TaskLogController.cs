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
    public class TaskLogController : ControllerBase
    {
        ITaskLogBusinessLogic TaskLogBusinessLogic;

        public TaskLogController(ITaskLogBusinessLogic Repo)
        {
            TaskLogBusinessLogic =Repo;
        }
        [Route("DeleteTaskLog/{id}")]
        [HttpDelete]
        public int DeleteTaskLog(int id)
        {
            return TaskLogBusinessLogic.DeleteTaskLog(id);
        }


        [Route("GetTaskLogById/{id}")]
        [HttpGet]
        public TaskLog GetByTaskLogId(int id)
        {
            return TaskLogBusinessLogic.GetByTaskLogId(id);
        }


        [Route("GetTaskLog")]
        [HttpGet]
        public List<TaskLog> GetTaskLogs()
        {
            return TaskLogBusinessLogic.GetTaskLogs();
        }


        [Route("AddTaskLog")]
        [HttpPost]
        public int InsertTaskLog(TaskLog TaskLog)
        {
            return TaskLogBusinessLogic.InsertTaskLog(TaskLog);
        }


        [Route("UpdateTaskLog")]
        [HttpPut]
        public bool UpdateTaskLog(TaskLog TaskLog)
        {
           
                return TaskLogBusinessLogic.UpdateTaskLog(TaskLog);
           
        }
}}
