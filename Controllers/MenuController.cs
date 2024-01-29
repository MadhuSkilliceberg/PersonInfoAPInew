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
    public class MenuController : ControllerBase
    {
        IMenuBusinessLogic MenuBusinessLogic;

        public MenuController(IMenuBusinessLogic Repo)
        {
            MenuBusinessLogic =Repo;
        }
        [Route("DeleteMenu/{Id}")]
        [HttpDelete]
        public int DeleteMenu(int id)
        {
            return MenuBusinessLogic.DeleteMenu(id);
        }


        [Route("GetMenuById/{Id}")]
        [HttpGet]
        public Menu GetByMenuId(int id)
        {
            return MenuBusinessLogic.GetByMenuId(id);
        }


        [Route("GetMenu")]
        [HttpGet]
        public List<Menu> GetMenus()
        {
            return MenuBusinessLogic.GetMenus();
        }


        [Route("AddMenu")]
        [HttpPost]
        public int InsertMenu(Menu Menu)
        {
            return MenuBusinessLogic.InsertMenu(Menu);
        }


        [Route("UpdateMenu")]
        [HttpPut]
        public bool UpdateMenu(Menu Menu)
        {
           
                return MenuBusinessLogic.UpdateMenu(Menu);
           
        }
}}
