using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
  public  interface IUserCompanyRepo
    {
        public List<UserCompany> GetUsers();
        public int InsertUser(UserCompany user);

        public int UpdateUser(UserCompany user);

        public int DeleteUser(int id);

        public UserCompany GetByUserId(int id);

        public bool AddUserCompanies(List<UserCompany> userCompanies);
    }
}
