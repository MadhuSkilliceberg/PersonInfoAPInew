using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class MarritalStatusBussinessLogic: IMarritalStatusBussinessLogic
    {
        IMarritalStatusRepo userRepository;
        public MarritalStatusBussinessLogic(IMarritalStatusRepo Repo)
        {
            userRepository = Repo;
        }

        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public MarritalStatus GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }

        public List<MarritalStatus> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public bool InsertUser(MarritalStatus user)
        {
            return userRepository.InsertUser(user);
        }

        public bool UpdateUser(MarritalStatus user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
