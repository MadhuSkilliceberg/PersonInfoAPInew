using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IUserContactRepo
    {
        public Task<List<UserContact>> GetUserContacts();

        public Task<List<UserContact>> GetUserContactsByUserId(int userId);

        public Task<int> AddUserContact(UserContact user);

        public Task<int> UpdateUserContact(UserContact user);



        public Task<UserContact> GetUserContactById(int id);
        public Task<int> DeleteUserContactById(int id);

        public Task<int> AddUserContacts(List<UserContact> userContacts);

        public Task<int> UpdateUserContacts(List<UserContact> userContacts);
    }
}
