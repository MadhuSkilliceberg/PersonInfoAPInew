using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IUserEducationDetailRepo
    {
        //This method used to get user education details 
        public Task<List<UserEducationDetail>> GetUserEducationDetails();

        public Task<List<UserEducationDetail>> GetUserEducationDetailsByUserId(int userId);

        //This method used to save one user education details 
        public Task<int> InsertUserEducationDetail(UserEducationDetail userEducationDetail);

        //This method used to save more than one user education details 
        public Task<int> InsertUserEducationDetails(List<UserEducationDetail> userEducationDetail);

        //This method used to update one user education details 
        public Task<int> UpdateUserEducationDetail(UserEducationDetail userEducationDetail);

        //This method used to update more than one user education details 
        public Task<int> UpdateUserEducationDetails(List<UserEducationDetail> userEducationDetail);

        //This method used to delete user education details 
        public Task<int> DeleteUserEducationDetail(int id);

        //This method used to get one user education details by Id
        public Task<UserEducationDetail> GetUserEducationDetailsById(int id);

    }
}
