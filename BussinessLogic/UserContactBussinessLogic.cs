using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserContactBussinessLogic: IUserContactBussinessLogic
    {
       public IUserContactRepo userContactRepo;
        public UserContactBussinessLogic(IUserContactRepo Repo)
        {
            userContactRepo = Repo;
        }

        public async Task<int> DeleteUserContactById(int id)
        {
            return await userContactRepo.DeleteUserContactById(id);
        }

        public async Task<List<UserContact>> GetUserContacts()
        {
            return await userContactRepo.GetUserContacts();
        }

        public async Task<UserContact> GetUserContactById(int id)
        {
            return await userContactRepo.GetUserContactById(id);
        }

        public async Task<int> AddUserContact(UserContact userContact)
        {
            return await userContactRepo.AddUserContact(userContact);
        }

        public async Task<int> AddUserContacts(List<UserContact> userContact)
        {
            return await userContactRepo.AddUserContacts(userContact);
        }

        public async Task<int> UpdateUserContact(UserContact userContact)
        {
            return await userContactRepo.UpdateUserContact(userContact);
        }

        public async Task<int> UpdateUserContacts(List<UserContact> userContact)
        {
            return await userContactRepo.UpdateUserContacts(userContact);
        }

        public async Task<List<UserContact>> GetUserContactsByUserId(int userId)
        {
            return await userContactRepo.GetUserContactsByUserId(userId);
        }
    }
}
