using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ICoutryStateRepo
    {
        public List<CoutryState> GetUsers();
        public int InsertUser(CoutryState user);

        public bool UpdateUser(CoutryState user);

        public int DeleteUser(int id);

        public CoutryState GetByUserId(int id);

        //public List<CoutryState> GetCoutryStates();
        public List<string> GetByCountryStates(string statename);

        public List<string> GetByStatesCountry(string countryname);



    }
}
