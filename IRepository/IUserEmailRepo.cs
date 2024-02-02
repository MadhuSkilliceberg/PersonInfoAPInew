using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public  interface IUserEmailRepo
    {
        public Task<List<UserEmail>> GetUserEmails();

        public Task<List<UserEmail>> GetUserEmailsByUserId(int userId);

        public Task<int> AddUserEmail(UserEmail userEmail);

        public Task<int> AddUserEmails(List<UserEmail> userEmails);

        public Task<int> UpdateUserEmail(UserEmail userEmail);

        public Task<int> UpdateUserEmails(List<UserEmail> userEmails);

        public Task<int> DeleteUserEmails(int id);

        public Task<UserEmail> GetUserEmailById(int id);
    }
}
