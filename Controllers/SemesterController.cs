using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
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
    public class SemesterController : ControllerBase
    {
        ISemesterBusinessLogic semesters;

        public SemesterController(ISemesterBusinessLogic logic)
        {
            semesters = logic;
        }

        [Route("DeleteSemesters/{id}")]
        [HttpDelete]
        public int DeleteSemester(int id)
        {
            return semesters.DeleteSemester(id);
        }


        [Route("GetSemestersById/{id}")]
        [HttpGet]
        public Semester GetBySemesterId(int id)
        {
            return semesters.GetBySemesterId(id);
        }

        [Route("GetSemesters")]
        [HttpGet]
        public List<Semester> GetSemester()
        {
            return semesters.GetSemester();
        }


        [Route("AddSemesters")]
        [HttpPost]
        public int InsertSemester(Semester semester)
        {
            return semesters.InsertSemester(semester);
        }


        [Route("UpdateSemesters")]
        [HttpPut]
        public int UpdateSemester(Semester semester)
        {
            return semesters.UpdateSemester(semester);
        }
    }
}
