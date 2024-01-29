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



        public int DeleteUser(int id)
        {
            var k = Context.Categories.Where(a => a.Id == id).FirstOrDefault();
            Context.Categories.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Category GetByUserId(int id)
        {
            var k = Context.Categories.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<Category> GetUsers()
        {
            return Context.Categories.ToList();
        }

        public int InsertUser(Category user)
        {
            Context.Categories.Add(user);
            Context.SaveChanges();
            return user.Id;
        }

        public bool UpdateUser(Category user)
        {
            Context.Categories.Update(user);
            Context.SaveChanges();
            return true;
        }


       

    }
}
