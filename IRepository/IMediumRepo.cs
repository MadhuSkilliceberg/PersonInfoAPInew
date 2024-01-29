using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
  public  interface IMediumRepo
    {
        public List<Medium> GetUsers();
        public bool  InsertUser(Medium user);

        public bool UpdateUser(Medium user);

        public int DeleteUser(int id);

        public Medium GetByUserId(int id);

        public Medium GetByUserName(string mediumName);

   


    }
}
