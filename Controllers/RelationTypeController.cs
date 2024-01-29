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
    public class RelationTypeController : ControllerBase
    {
        IRelationTypeBusinessLogic relation1;

     public   RelationTypeController(IRelationTypeBusinessLogic Repo)
        {
            relation1 = Repo;
        }

        [Route("DeleteRelationTypes/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return relation1.DeleteUser(id);
        }


        [Route("GetRelationTypesById/{id}")]
        [HttpGet]
        public RelationType GetByUserId(int id)
        {
            return relation1.GetByUserId(id);
        }


        [Route("GetRelationTypes")]
        [HttpGet]
        public List<RelationType> GetUsers()
        {
            return relation1.GetUsers();
        }


        [Route("AddRelationTypes")]
        [HttpPost]
        public int InsertUser(RelationType relationType)
        {
            return relation1.InsertUser(relationType);
        }


        [Route("UpdateRelationTypes")]
        [HttpPut]
        public int UpdateUser(RelationType relationType)
        {
            return relation1.UpdateUser(relationType);
        }
    }
}
