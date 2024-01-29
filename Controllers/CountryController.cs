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
    public class CountryController : ControllerBase
    {
        ICountryBussinessLogic userRepository;
        public CountryController(ICountryBussinessLogic Repo)
        {
            userRepository = Repo;
        }

        [Route("DeleteCountries/{id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }


        [Route("GetCountriesById/{id}")]
        [HttpGet]
        public Country GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }


        [Route("GetCountries")]
        [HttpGet]
        public List<Country> GetUsers()
        {
            return userRepository.GetUsers();
        }

        [Route("GetCountriesADO")]
        [HttpGet]
        public List<Country> GetCountries()
        {
            return userRepository.GetCountries();
        }

        [Route("AddCountries")]
        [HttpPost]
        public bool InsertUser(Country user)
        {
            return userRepository.InsertUser(user);
        }


        [Route("InsertUserADO")]
        [HttpPost]
        public int InsertUserADO(Country user)
        {
            return userRepository.InsertUserADO(user);
        }


        [Route("UpdateCountries")]
        [HttpPut]
        public bool UpdateUser(Country user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
