using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface ICountryRepo
    {
        public List<Country> GetUsers();
        public bool InsertUser(Country user);

        public bool UpdateUser(Country user);

        public int DeleteUser(int id);

        public Country GetByUserId(int id);

        public List<Country> GetCountries();

        public int InsertUserADO(Country user);

    }
}
