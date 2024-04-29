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
    public class LocationController : ControllerBase
    {
        ILocationBusinessLogic LocationBusinessLogic;

        public LocationController(ILocationBusinessLogic Location)
        {
            LocationBusinessLogic =Location;
        }
        [Route("DeleteLocations/{Id}")]
        [HttpDelete]
        public int DeleteLocation(int id)
        {
            return LocationBusinessLogic.DeleteLocation(id);
        }


        [Route("GetLocationsById/{Id}")]
        [HttpGet]
        public Location GetByLocationId(int id)
        {
            return LocationBusinessLogic.GetByLocationId(id);
        }


        [Route("GetLocations")]
        [HttpGet]
        public List<Location> GetLocations()
        {
            return LocationBusinessLogic.GetLocations();
        }


        [Route("AddLocations")]
        [HttpPost]
        public int InsertLocation(Location Location)
        {
            return LocationBusinessLogic.InsertLocation(Location);
        }


        [Route("UpdateLocations")]
        [HttpPut]
        public bool UpdateLocation(Location Location)
        {
                return LocationBusinessLogic.UpdateLocation(Location);
           
        }
}}
