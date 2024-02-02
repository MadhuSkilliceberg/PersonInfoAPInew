using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserEducationDetailBusinessLogics : IUserEducationDetailsBussinessLogic
    {
      private readonly IUserEducationDetailRepo userEducationDetailRepo;
        public UserEducationDetailBusinessLogics(IUserEducationDetailRepo Repo)
        {
            userEducationDetailRepo = Repo;
        }

        public async Task<int> DeleteUserEducationDetail(int id)
        {
            return await userEducationDetailRepo.DeleteUserEducationDetail(id);
        }

        public async Task<List<UserEducationDetail>> GetUserEducationDetails()
        {
           return await userEducationDetailRepo.GetUserEducationDetails();
        }

        public async Task<UserEducationDetail> GetUserEducationDetailsById(int id)
        {
           return await userEducationDetailRepo.GetUserEducationDetailsById(id);
        }

        public async Task<List<UserEducationDetail>> GetUserEducationDetailsByUserId(int userId)
        {
            return await userEducationDetailRepo.GetUserEducationDetailsByUserId(userId);
        }

        public async Task<int> InsertUserEducationDetail(UserEducationDetail userEducationDetail)
        {
           return await userEducationDetailRepo.InsertUserEducationDetail(userEducationDetail);
        }

        public async Task<int> InsertUserEducationDetails(List<UserEducationDetail> userEducationDetail)
        {
           return await userEducationDetailRepo.InsertUserEducationDetails(userEducationDetail);
        }

        public async Task<int> UpdateUserEducationDetail(UserEducationDetail userEducationDetail)
        {
           return await userEducationDetailRepo.UpdateUserEducationDetail(userEducationDetail);
        }

        public async Task<int> UpdateUserEducationDetails(List<UserEducationDetail> userEducationDetail)
        {
           return await userEducationDetailRepo.UpdateUserEducationDetails(userEducationDetail);
        }
    }
}
