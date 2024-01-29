using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class MediumBussinessLogic : IMediumBussinessLogic
    {


        IMediumRepo userRepository;
        public MediumBussinessLogic(IMediumRepo Repo)
        {
            userRepository = Repo;
        }

       

        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public Medium GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }

        public Medium GetByUserName(string mediumName)
        {
            return userRepository.GetByUserName(mediumName);

        }

        public List<Medium> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public bool InsertUser(Medium user)
        {
            return userRepository.InsertUser(user);
        }

        public bool UpdateUser(Medium user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
