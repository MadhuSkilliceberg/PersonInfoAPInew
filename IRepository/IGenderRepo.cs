using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IGenderRepo
    {
        public List<Gender> GetUsers();
        public bool InsertUser(Gender user);

        public bool UpdateUser(Gender user);

        public int DeleteUser(int id);

        public Gender GetByUserId(int id);
    }
}
