using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
   public interface ICategoryBussinessLogic
    {
        public List<Category> GetCategories();
        public int SaveCategory(Category Category);

        public bool UpdateCategory(Category Category);

        public int DeleteCategory(int id);

        public Category GetCategoryById(int id);

        public List<object> TreeHierarchical();

        public List<object> TreeHierarchical1(List<int> parentIds);
    }
}
