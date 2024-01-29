using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CoutryStateBusinessLogic : ICoutryStateBusinessLogic
    {
        ICoutryStateRepo coutryStateRepo;

        public CoutryStateBusinessLogic(ICoutryStateRepo Repo)
        {
            coutryStateRepo = Repo;
        }
        public int DeleteUser(int id)
        {
            return coutryStateRepo.DeleteUser(id);
        }

        public CoutryState GetByUserId(int id)
        {
            return coutryStateRepo.GetByUserId(id);
        }

        public List<CoutryState> GetUsers()
        {
            return coutryStateRepo.GetUsers();
        }

        public int InsertUser(CoutryState user)
        {
            return coutryStateRepo.InsertUser(user);
        }

        public bool UpdateUser(CoutryState user)
        {
            return coutryStateRepo.UpdateUser(user);
        }
        public List<string> GetByCountryStates(string statename)

        {

            return coutryStateRepo.GetByCountryStates(statename);
        }

        public List<string> GetByStatesCountry(string countryname)
        {
            return coutryStateRepo.GetByStatesCountry(countryname);
        }


        //public List<CoutryState> GetCoutryStates()
        //{
        //    return coutryStateRepo.GetCoutryStates();
        //}

    }
}
