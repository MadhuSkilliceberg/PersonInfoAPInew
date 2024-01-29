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
    public class CoutryStateController : ControllerBase
    {
        ICoutryStateBusinessLogic coutry;

        public    CoutryStateController(ICoutryStateBusinessLogic Repo)
        {
            coutry = Repo ;
        }

        [Route("DeleteCoutryStates/{Id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return coutry.DeleteUser(id);
        }


        [Route("GetCoutryStatesById/{Id}")]
        [HttpGet]
        public CoutryState GetByUserId(int id)
        {
            return coutry.GetByUserId(id);
        }


        [Route("GetCoutryStates")]
        [HttpGet]
        public List<CoutryState> GetUsers()
        {
            return coutry.GetUsers();
        }


        [Route("AddCoutryStates")]
        [HttpPost]
        public int InsertUser(CoutryState user)
        {
            return coutry.InsertUser(user);
        }


        [Route("UpdateCoutryStates")]
        [HttpPut]
        public bool UpdateUser(CoutryState user)
        {
            return coutry.UpdateUser(user);
        }


        [Route("GetCountryStates")]
        [HttpGet]
        public List<string> GetByCountryStates(string statename)

        {

            return coutry.GetByCountryStates(statename);
        }



        [Route("GetStatesCountry")]
        [HttpGet]
        public List<string> GetByStatesCountry(string countryname)
        {
            return coutry.GetByStatesCountry(countryname);
        }
    }
}
