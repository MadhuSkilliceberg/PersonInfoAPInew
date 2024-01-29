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
    public class CategoryController : ControllerBase
    {
        ICategoryBussinessLogic categoryBussinessLogic;
        public CategoryController(ICategoryBussinessLogic categoryBussinessLogic)
        {
            this.categoryBussinessLogic = categoryBussinessLogic;
        }

        [Route("DeleteCategory/{id}")]
        [HttpDelete]
        public int DeleteUser(int id)
        {
            return categoryBussinessLogic.DeleteUser(id);
        }


        [Route("GetCategoryById/{id}")]
        [HttpGet]
        public Category GetByUserId(int id)
        {
            return categoryBussinessLogic.GetByUserId(id);
        }


        [Route("GetCategory")]
        [HttpGet]
        public List<Category> GetUsers()
        {
            return categoryBussinessLogic.GetUsers();
        }


        [Route("AddCategory")]
        [HttpPost]
        public int InsertUser(Category user)
        {
            return categoryBussinessLogic.InsertUser(user);
        }


        [Route("UpdateCategory")]
        [HttpPut]
        public bool UpdateUser(Category user)
        {
            return categoryBussinessLogic.UpdateUser(user);
        }

        [Route("TreeHierarchical")]
        [HttpGet]
        public List<object> TreeHierarchical()
        {
            return categoryBussinessLogic.TreeHierarchical();
        }

    }
}
