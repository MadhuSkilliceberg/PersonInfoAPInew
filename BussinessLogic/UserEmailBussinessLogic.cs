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
       public IUserEmailRepo userRepository;
        public UserEmailBussinessLogic(IUserEmailRepo Repo)
        {
            userRepository = Repo;
        }

        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public UserEmail GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }

        public List<UserEmail> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public bool InsertUser(UserEmail user)
        {
            return userRepository.InsertUser(user);
        }

        public bool UpdateUser(UserEmail user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
