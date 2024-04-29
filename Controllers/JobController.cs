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
    public class JobController : ControllerBase
    {
        IJobBusinessLogic JobBusinessLogic;

        public JobController(IJobBusinessLogic job)
        {
            JobBusinessLogic =job;
        }
        [Route("DeleteJobs/{Id}")]
        [HttpDelete]
        public int DeleteJob(int id)
        {
            return JobBusinessLogic.DeleteJob(id);
        }


        [Route("GetJobsById/{Id}")]
        [HttpGet]
        public Job GetByJobId(int id)
        {
            return JobBusinessLogic.GetByJobId(id);
        }


        [Route("GetJobs")]
        [HttpGet]
        public List<Job> GetJobs()
        {
            return JobBusinessLogic.GetJobs();
        }


        [Route("AddJobs")]
        [HttpPost]
        public int InsertJob(Job Job)
        {
            return JobBusinessLogic.InsertJob(Job);
        }


        [Route("UpdateJobs")]
        [HttpPut]
        public bool UpdateJob(Job Job)
        {
           
                return JobBusinessLogic.UpdateJob(Job);
           
        }


        [Route("GetLookUpSearch/{name}")]
        [HttpGet]
        public List<Skill> GetLookUpSearch(string name)
        {
            return JobBusinessLogic.GetLookUpSearch(name);
        }
    }
}
