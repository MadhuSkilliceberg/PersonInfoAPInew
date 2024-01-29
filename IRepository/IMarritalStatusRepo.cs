using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
  public  interface IMarritalStatusRepo
    {
        public List<MarritalStatus> GetUsers();
        public bool InsertUser(MarritalStatus user);

        public bool UpdateUser(MarritalStatus user);

        public int DeleteUser(int id);

        public MarritalStatus GetByUserId(int id);
    }
}
