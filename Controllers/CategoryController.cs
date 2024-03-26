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
        public int DeleteCategory(int id)
        {
            return categoryBussinessLogic.DeleteCategory(id);
        }


        [Route("GetCategoryById/{id}")]
        [HttpGet]
        public Category GetCategoryById(int id)
        {
            return categoryBussinessLogic.GetCategoryById(id);
        }


        [Route("GetCategory")]
        [HttpGet]
        public List<Category> GetCategories()
        {
            return categoryBussinessLogic.GetCategories();
        }


        [Route("AddCategory")]
        [HttpPost]
        public int SaveCategory(Category user)
        {
            return categoryBussinessLogic.SaveCategory(user);
        }


        [Route("UpdateCategory")]
        [HttpPut]
        public bool UpdateCategory(Category user)
        {
            return categoryBussinessLogic.UpdateCategory(user);
        }

        [Route("TreeHierarchical")]
        [HttpGet]
        public List<object> TreeHierarchical()
        {
            return categoryBussinessLogic.TreeHierarchical();
        }
        [Route("TreeHierarchical1")]
        [HttpPost]
        public List<object> TreeHierarchical1(List<int> ids)
        {
            return categoryBussinessLogic.TreeHierarchical1(ids);
        }

        

    }
}
