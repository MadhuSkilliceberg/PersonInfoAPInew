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
    public class TaskDocumentController : ControllerBase
    {
        ITaskDocumentBusinessLogic TaskDocumentBusinessLogic;

        public TaskDocumentController(ITaskDocumentBusinessLogic Repo)
        {
            TaskDocumentBusinessLogic =Repo;
        }
        [Route("DeleteTaskDocuments/{Id}")]
        [HttpDelete]
        public int DeleteTaskDocument(int id)
        {
            return TaskDocumentBusinessLogic.DeleteTaskDocument(id);
        }


        [Route("GetTaskDocumentsById/{Id}")]
        [HttpGet]
        public TaskDocument GetByTaskDocumentId(int id)
        {
            return TaskDocumentBusinessLogic.GetByTaskDocumentId(id);
        }


        [Route("GetTaskDocuments")]
        [HttpGet]
        public List<TaskDocument> GetTaskDocuments()
        {
            return TaskDocumentBusinessLogic.GetTaskDocuments();
        }


        [Route("AddTaskDocuments")]
        [HttpPost]
        public int InsertTaskDocument(TaskDocument TaskDocument)
        {
            return TaskDocumentBusinessLogic.InsertTaskDocument(TaskDocument);
        }


        [Route("UpdateTaskDocuments")]
        [HttpPut]
        public bool UpdateTaskDocument(TaskDocument TaskDocument)
        {
           
                return TaskDocumentBusinessLogic.UpdateTaskDocument(TaskDocument);
           
        }
}}
