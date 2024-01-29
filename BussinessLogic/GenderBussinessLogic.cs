using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class GenderBussinessLogic: IGenderBussinessLogic
    {
        IGenderRepo userRepository;
        public GenderBussinessLogic(IGenderRepo Repo)
        {
            userRepository = Repo;
        }

        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public Gender GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }

        public List<Gender> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public bool InsertUser(Gender user)
        {
            return userRepository.InsertUser(user);
        }

        public bool UpdateUser(Gender user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
