using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class CategoryRepo: ICategoryRepo
    {
         PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        //private readonly PersonsInfoV3NewContext Context;
        //public CategoryRepo(PersonsInfoV3NewContext personsInfoV2New)
        //{
        //    this.Context = personsInfoV2New;
        //}



        public int DeleteCategory(int id)
        {
            var k = Context.Categories.Where(a => a.Id == id).FirstOrDefault();
            Context.Categories.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Category GetCategoryById(int id)
        {
            var k = Context.Categories.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<Category> GetCategories()
        {
            return Context.Categories.ToList();
        }

        public int SaveCategory(Category Category)
        {
            Context.Categories.Add(Category);
            Context.SaveChanges();
            return Category.Id;
        }

        public bool UpdateCategory(Category Category)
        {
            Context.Categories.Update(Category);
            Context.SaveChanges();
            return true;
        }


       

    }
}
