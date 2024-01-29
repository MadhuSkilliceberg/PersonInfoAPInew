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
    public class MenuListController : ControllerBase
    {
        IMenuListBusinessLogic MenuListBusinessLogic;

        public MenuListController(IMenuListBusinessLogic Repo)
        {
            MenuListBusinessLogic =Repo;
        }
        [Route("DeleteMenuList/{Id}")]
        [HttpDelete]
        public int DeleteMenuList(int id)
        {
            return MenuListBusinessLogic.DeleteMenuList(id);
        }


        [Route("GetMenuListById/{Id}")]
        [HttpGet]
        public MenuList GetByMenuListId(int id)
        {
            return MenuListBusinessLogic.GetByMenuListId(id);
        }


        [Route("GetMenuLists")]
        [HttpGet]
        public List<MenuList> GetMenuLists()
        {
            return MenuListBusinessLogic.GetMenuLists();
        }


        [Route("AddMenuList")]
        [HttpPost]
        public int InsertMenuList(MenuList MenuList)
        {
            return MenuListBusinessLogic.InsertMenuList(MenuList);
        }


        [Route("UpdateMenuList")]
        [HttpPut]
        public bool UpdateMenuList(MenuList MenuList)
        {
           
                return MenuListBusinessLogic.UpdateMenuList(MenuList);
           
        }
}}
