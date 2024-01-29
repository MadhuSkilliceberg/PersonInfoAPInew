using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyController : ControllerBase
    {
        IFamilyBusinessLogic family1;
     public   FamilyController(IFamilyBusinessLogic Repo)
        {
            family1 = Repo;
        }
        [Route("DeleteFamily/{id}")]
        [HttpDelete]
        public bool DeleteFamily(int id)
        {
            return family1.DeleteFamily(id);
        }

        [Route("GetFamilyById/{id}")]
        [HttpGet]
        public Family GetById(int id)
        {
            return family1.GetById(id);
        }

        [Route("GetFamilies")]
        [HttpGet]
        public List<Family> GetFamilies()
        {
            return family1.GetFamilies();

        }

        [Route("AddFamily")]
        [HttpPost]
        public bool InsertFamily(Family family)
        {
            return family1.InsertFamily(family);
        }

        [Route("UpdateFamily")]
        [HttpPut]
        public bool UpdateFamily(Family family)
        {
            return family1.UpdateFamily(family);
        }

    }
}
