using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CountryBussinessLogic: ICountryBussinessLogic
    {
        ICountryRepo userRepository;
        public CountryBussinessLogic(ICountryRepo Repo)
        {
            userRepository = Repo;
        }

        public int DeleteUser(int id)
        {
            return userRepository.DeleteUser(id);
        }

        public Country GetByUserId(int id)
        {
            return userRepository.GetByUserId(id);
        }

        public List<Country> GetCountries()
        {
            return userRepository.GetCountries();
        }

        public List<Country> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public bool InsertUser(Country user)
        {
            return userRepository.InsertUser(user);
        }

        public int InsertUserADO(Country user)
        {
            return userRepository.InsertUserADO(user);
        }

        public bool UpdateUser(Country user)
        {
            return userRepository.UpdateUser(user);
        }
    }
}
