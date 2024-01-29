using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IUserContactRepo
    {
        public List<UserContact> GetUsers();
        public bool InsertUser(UserContact user);

        public bool UpdateUser(UserContact user);

        public int DeleteUser(int id);

        public UserContact GetByUserId(int id);
        public bool AddUserContacts(List<UserContact> userContacts);
    }
}
