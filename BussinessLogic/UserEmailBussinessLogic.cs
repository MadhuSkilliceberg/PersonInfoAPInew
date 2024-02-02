using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserEmailBussinessLogic: IUserEmailBussinessLogic
    {
       public IUserEmailRepo  userRepository;
        public  UserEmailBussinessLogic(IUserEmailRepo Repo)
        {
             userRepository = Repo;
        }

        public async Task<int> DeleteUserEmails(int id)
        {
            return await userRepository.DeleteUserEmails(id);
        }

        public async Task<UserEmail> GetUserEmailById(int id)
        {
            return await  userRepository.GetUserEmailById(id);
        }

        public async Task<List<UserEmail>> GetUserEmails()
        {
            return await userRepository.GetUserEmails();
        }

        public async Task<int> AddUserEmail(UserEmail  userEmail)
        {
            return await userRepository.AddUserEmail(userEmail);
        }

        public async Task<int> UpdateUserEmail(UserEmail userEmail)
        {
            return await userRepository.UpdateUserEmail(userEmail);
        }

        public async Task<int> AddUserEmails(List<UserEmail> userEmails)
        {
            return await userRepository.AddUserEmails(userEmails);
        }

        public async Task<int> UpdateUserEmails(List<UserEmail> userEmails)
        {
            return await userRepository.UpdateUserEmails(userEmails);
        }

        public async Task<List<UserEmail>> GetUserEmailsByUserId(int userId)
        {
            return await userRepository.GetUserEmailsByUserId(userId);
        }
    }
}
