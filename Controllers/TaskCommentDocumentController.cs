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
    public class TaskCommentDocumentController : ControllerBase
    {
        ITaskCommentDocumentBusinessLogic TaskCommentDocumentBusinessLogic;

        public TaskCommentDocumentController(ITaskCommentDocumentBusinessLogic Repo)
        {
            TaskCommentDocumentBusinessLogic =Repo;
        }
        [Route("DeleteTaskCommentDocuments/{Id}")]
        [HttpDelete]
        public int DeleteTaskCommentDocument(int id)
        {
            return TaskCommentDocumentBusinessLogic.DeleteTaskCommentDocument(id);
        }


        [Route("GetTaskCommentDocumentsById/{Id}")]
        [HttpGet]
        public TaskCommentDocument GetByTaskCommentDocumentId(int id)
        {
            return TaskCommentDocumentBusinessLogic.GetByTaskCommentDocumentId(id);
        }


        [Route("GetTaskCommentDocuments")]
        [HttpGet]
        public List<TaskCommentDocument> GetTaskCommentDocuments()
        {
            return TaskCommentDocumentBusinessLogic.GetTaskCommentDocuments();
        }


        [Route("AddTaskCommentDocuments")]
        [HttpPost]
        public int InsertTaskCommentDocument(TaskCommentDocument TaskCommentDocument)
        {
            return TaskCommentDocumentBusinessLogic.InsertTaskCommentDocument(TaskCommentDocument);
        }


        [Route("UpdateTaskCommentDocuments")]
        [HttpPut]
        public bool UpdateTaskCommentDocument(TaskCommentDocument TaskCommentDocument)
        {
           
                return TaskCommentDocumentBusinessLogic.UpdateTaskCommentDocument(TaskCommentDocument);
           
        }
}}
