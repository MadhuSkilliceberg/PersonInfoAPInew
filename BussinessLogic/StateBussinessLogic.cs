using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class StateBussinessLogic: IStateBussinessLogic
    {
        IStateRepo userRepository;
        public StateBussinessLogic(IStateRepo Repo)
        {
            userRepository = Repo;
        }

        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public List<string> GetAllFamilyDetailsByPuttingUser(string username)
        {
            List<string> s = new List<string>();
            return s;
           // return userRepository.GetAllFamilyDetailsByPuttingUser(username);
        }

            public State GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }

        public List<State> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public bool InsertUser(State user)
        {
            return userRepository.InsertUser(user);
        }

        public bool UpdateUser(State user)
        {
            return userRepository.UpdateUser(user);
        }

        //int IStateBussinessLogic.DeleteUser(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //List<string> IStateBussinessLogic.GetAllFamilyDetailsByPuttingUser(string username)
        //{
        //    throw new NotImplementedException();
        //}

        //State IStateBussinessLogic.GetByUserId(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //List<State> IStateBussinessLogic.GetUsers()
        //{
        //    throw new NotImplementedException();
        //}

        //string IStateBussinessLogic.InsertUser(State user)
        //{
        //    throw new NotImplementedException();
        //}

        //bool IStateBussinessLogic.UpdateUser(State user)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
