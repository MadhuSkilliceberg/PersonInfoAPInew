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
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataController : ControllerBase
    {
        IbussiUserData ibussi;
        public UserDataController(IbussiUserData data)
        {
            ibussi = data;
        }


        [Route("api/GetUserDatasss")]
        [HttpGet]
        public List<User> GetUserDatasss()
        {
            return ibussi.GetUserDatasss();
        }
    }
}
