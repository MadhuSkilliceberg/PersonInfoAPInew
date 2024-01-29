using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface ICategoryRepo
    {
        public List<Category> GetUsers();
        public int InsertUser(Category user);

        public bool UpdateUser(Category user);

        public int DeleteUser(int id);

        public Category GetByUserId(int id);
    }
}
