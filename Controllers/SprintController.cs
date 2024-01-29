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
    public class SprintController : ControllerBase
    {
        ISprintBusinessLogic SprintBusinessLogic;

        public SprintController(ISprintBusinessLogic Repo)
        {
            SprintBusinessLogic =Repo;
        }
        [Route("DeleteSprint/{Id}")]
        [HttpDelete]
        public int DeleteSprint(int id)
        {
            return SprintBusinessLogic.DeleteSprint(id);
        }


        [Route("GetSprintById/{Id}")]
        [HttpGet]
        public Sprint GetBySprintId(int id)
        {
            return SprintBusinessLogic.GetBySprintId(id);
        }


        [Route("GetSprint")]
        [HttpGet]
        public List<Sprint> GetSprints()
        {
            return SprintBusinessLogic.GetSprints();
        }


        [Route("AddSprint")]
        [HttpPost]
        public int InsertSprint(Sprint Sprint)
        {
            return SprintBusinessLogic.InsertSprint(Sprint);
        }


        [Route("UpdateSprint")]
        [HttpPut]
        public bool UpdateSprint(Sprint Sprint)
        {
           
                return SprintBusinessLogic.UpdateSprint(Sprint);
           
        }
}}
