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
    public class StatusController : ControllerBase
    {
        IStatusBusinessLogic StatusBusinessLogic;

        public StatusController(IStatusBusinessLogic Repo)
        {
            StatusBusinessLogic =Repo;
        }
        [Route("DeleteStatus/{Id}")]
        [HttpDelete]
        public int DeleteStatus(int id)
        {
            return StatusBusinessLogic.DeleteStatus(id);
        }


        [Route("GetStatusById/{Id}")]
        [HttpGet]
        public Status GetByStatusId(int id)
        {
            return StatusBusinessLogic.GetByStatusId(id);
        }


        [Route("GetStatus")]
        [HttpGet]
        public List<Status> GetStatuss()
        {
            return StatusBusinessLogic.GetStatuss();
        }


        [Route("AddStatus")]
        [HttpPost]
        public int InsertStatus(Status Status)
        {
            return StatusBusinessLogic.InsertStatus(Status);
        }


        [Route("UpdateStatus")]
        [HttpPut]
        public bool UpdateStatus(Status Status)
        {
           
                return StatusBusinessLogic.UpdateStatus(Status);
           
        }
}}
