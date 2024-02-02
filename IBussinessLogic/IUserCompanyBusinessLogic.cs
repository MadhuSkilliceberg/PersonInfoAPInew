using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IUserCompanyBusinessLogic
    {

        public Task<List<UserCompany>> GetUserCompanies();

        public Task<List<UserCompany>> GetUserCompaniesByUserId(int userId);

        public Task<int> AddUserCompany(UserCompany user);

        public Task<int> UpdateUserCompany(UserCompany user);

        public Task<UserCompany> GetUserCompanyById(int id);
        public Task<int> DeleteUserCompanyById(int id);

        public Task<int> AddUserCompanies(List<UserCompany> userCompanies);

        public Task<int> UpdateUserCompanies(List<UserCompany> userCompanies);
    }
}
