using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.Repository;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserCompanyBusinessLogic : IUserCompanyBusinessLogic
    {
        private readonly IUserCompanyRepo userCompanyRepo;

        public  UserCompanyBusinessLogic(IUserCompanyRepo Repo)
        {
            userCompanyRepo = Repo;
             
        }
        public async Task<int> DeleteUserCompanyById(int id)
        {
            return await userCompanyRepo.DeleteUserCompanyById(id);
        }

        public async Task<List<UserCompany>> GetUserCompanies()
        {
            return await userCompanyRepo.GetUserCompanies();
        }

        public async Task<UserCompany> GetUserCompanyById(int id)
        {
            return await userCompanyRepo.GetUserCompanyById(id);
        }

        public async Task<int> AddUserCompany(UserCompany userCompany)
        {
            return await userCompanyRepo.AddUserCompany(userCompany);
        }

        public async Task<int> AddUserCompanies(List<UserCompany> userCompany)
        {
            return await userCompanyRepo.AddUserCompanies(userCompany);
        }

        public async Task<int> UpdateUserCompany(UserCompany userCompany)
        {
            return await userCompanyRepo.UpdateUserCompany(userCompany);
        }

        public async Task<int> UpdateUserCompanies(List<UserCompany> userCompany)
        {
            return await userCompanyRepo.UpdateUserCompanies(userCompany);
        }

        public async Task<List<UserCompany>> GetUserCompaniesByUserId(int userId)
        {
            return await userCompanyRepo.GetUserCompaniesByUserId(userId);
        }
    }
}

