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
    public class TaskCommentController : ControllerBase
    {
        ITaskCommentBusinessLogic TaskCommentBusinessLogic;

        public TaskCommentController(ITaskCommentBusinessLogic Repo)
        {
            TaskCommentBusinessLogic =Repo;
        }
        [Route("DeleteTaskComments/{id}")]
        [HttpDelete]
        public int DeleteTaskComment(int id)
        {
            return TaskCommentBusinessLogic.DeleteTaskComment(id);
        }


        [Route("GetTaskCommentsById/{id}")]
        [HttpGet]
        public TaskComment GetByTaskCommentId(int id)
        {
            return TaskCommentBusinessLogic.GetByTaskCommentId(id);
        }


        [Route("GetTaskComments")]
        [HttpGet]
        public List<TaskComment> GetTaskComments()
        {
            return TaskCommentBusinessLogic.GetTaskComments();
        }


        [Route("AddTaskComments")]
        [HttpPost]
        public int InsertTaskComment(TaskComment TaskComment)
        {
            return TaskCommentBusinessLogic.InsertTaskComment(TaskComment);
        }


        [Route("UpdateTaskComments")]
        [HttpPut]
        public bool UpdateTaskComment(TaskComment TaskComment)
        {
           
                return TaskCommentBusinessLogic.UpdateTaskComment(TaskComment);
           
        }
}}
