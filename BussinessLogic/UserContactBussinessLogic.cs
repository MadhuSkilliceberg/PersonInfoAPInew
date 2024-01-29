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
       public IUserContactRepo UserContactsRepository;
        public UserContactBussinessLogic(IUserContactRepo Repo)
        {
            UserContactsRepository = Repo;
        }

        public int DeleteUser(int id)
        {
            return UserContactsRepository.DeleteUser(id);
        }

        public UserContact GetByUserId(int id)
        {
            return UserContactsRepository.GetByUserId(id);
        }

        public List<UserContact> GetUsers()
        {
            return UserContactsRepository.GetUsers();
        }

        public bool InsertUser(UserContact user)
        {
            return UserContactsRepository.InsertUser(user);
        }

        public bool UpdateUser(UserContact user)
        {
            return UserContactsRepository.UpdateUser(user);
        }
    }
}
