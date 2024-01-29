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
        ICategoryRepo userRepository;
        public CategoryBussinessLogic(ICategoryRepo Repo)
        {
            userRepository = Repo;
        }

        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public Category GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }

        public List<Category> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public int InsertUser(Category user)
        {
            return userRepository.InsertUser(user);
        }

        public bool UpdateUser(Category user)
        {
            return userRepository.UpdateUser(user);
        }

        public List<object> TreeHierarchical()
        {
            List<Category> categories =  GetUsers();

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
    }
}
