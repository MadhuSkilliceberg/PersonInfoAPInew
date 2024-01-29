using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserCompanyBusinessLogic : IUserCompanyBusinessLogic
    {
        IUserCompanyRepo company;

        public  UserCompanyBusinessLogic(IUserCompanyRepo Repo)
        {
            company = Repo;
             
        }


        public int DeleteUser(int id)
        {
            return company.DeleteUser(id);
        }

        public UserCompany GetByUserId(int id)
        {
            return company.GetByUserId(id);
        }

        public List<UserCompany> GetUsers()
        {
            return company.GetUsers();
        }

        public int InsertUser(UserCompany user)
        {
            return company.InsertUser(user);
        }

        public int UpdateUser(UserCompany user)
        {
            return company.UpdateUser(user);
        }
    }
}
