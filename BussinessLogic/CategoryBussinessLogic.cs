using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CategoryBussinessLogic: ICategoryBussinessLogic
    {
        ICategoryRepo CategoryRepository;
        public CategoryBussinessLogic(ICategoryRepo Repo)
        {
            CategoryRepository = Repo;
        }

        public int DeleteCategory(int id)
        {
            return CategoryRepository.DeleteCategory(id);
        }

        public Category GetCategoryById(int id)
        {
            return CategoryRepository.GetCategoryById(id);
        }

        public List<Category> GetCategories()
        {
            return CategoryRepository.GetCategories();
        }

        public int SaveCategory(Category Category)
        {
            return CategoryRepository.SaveCategory(Category);
        }

        public bool UpdateCategory(Category Category)
        {
            return CategoryRepository.UpdateCategory(Category);
        }

        public List<object> TreeHierarchical()
        {
            List<Category> categories =  GetCategories();

            List<Category> rootCategories = categories.Where(c => !c.ParentCategoryId.HasValue).ToList();
            List<object> result = new List<object>();

            foreach (Category rootCategory in rootCategories)
            {
                result.Add(BuildCategoryTree(rootCategory, categories));
            }
            return result;
        }

       private  object BuildCategoryTree(Category category, List<Category> categories)
        {

            var children = categories.Where(c => c.ParentCategoryId == category.Id).ToList();
            if (children.Count == 0)
            {
                return new
                {   
                    
                    name = category.Name,
                    title = category.Id,
                    children = new List<object>()
                };
            }
            else
            {
                var childNodes = new List<object>();
                foreach (var child in children)
                {
                    childNodes.Add(BuildCategoryTree(child, categories));
                }

                return new
                {
                    name = category.Name,
                    title = category.Id,
                    children = childNodes
                };
            }
        }

        public List<object> TreeHierarchical1(List<int> parentIds)
        {

            Func<int, List<Category>> categoryLoader = parentId =>
            {
                // Fetch child categories for a given parent ID
                return GetCategories().Where(c => c.ParentCategoryId == parentId).ToList();
            };

            List<Category> rootCategories = GetCategories().Where(c => parentIds.Contains(c.Id)).ToList();
            List<object> result = new List<object>();

            foreach (Category rootCategory in rootCategories)
            {
                result.Add(BuildCategoryTree1(rootCategory, categoryLoader));
            }
            return result;
        }
        private object BuildCategoryTree1(Category category, Func<int, List<Category>> categoryLoader)
        {
            var children = categoryLoader(category.Id);

            if (children == null || children.Count == 0)
            {
                return new
                {
                    name = category.Name,
                    title = category.Id,
                    children = new List<object>()
                };
            }
            else
            {
                var childNodes = new List<object>();
                foreach (var child in children)
                {
                    childNodes.Add(BuildCategoryTree1(child, categoryLoader));
                }

                return new
                {
                    name = category.Name,
                    title = category.Id,
                    children = childNodes
                };
            }
        }


    }
}
