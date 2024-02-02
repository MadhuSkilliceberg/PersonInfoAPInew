using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserAddressDetailBusinessLogic: IUserAddressDetailBusinessLogic
    {
      private readonly  IUserAddressDetailRepository userAddressDetailRepository;

      public  UserAddressDetailBusinessLogic(IUserAddressDetailRepository Repo)
        {
            userAddressDetailRepository = Repo;
        }

        public async Task<int> AddUserAddressDetail(UserAddressDetail user)
        {
          return  await userAddressDetailRepository.AddUserAddressDetail(user);

        }

        public Task<int> AddUserAddressDetails(List<UserAddressDetail> userAddressDetails)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteUserAddressDetailById(int id)
        {
            return await userAddressDetailRepository.DeleteUserAddressDetailById(id);
        }

        
        public async Task<UserAddressDetail> GetUserAddressDetailById(int id)
        {
            return await userAddressDetailRepository.GetUserAddressDetailsById(id);
        }

        public async Task<List<UserAddressDetail>> GetUserAddressDetails()
        {
            return await userAddressDetailRepository.GetUserAddressDetails();
        }

        public async Task<List<UserAddressDetail>> GetUserAddressDetailsByUserId(int userId)
        {
            return await userAddressDetailRepository.GetUserAddressDetailsByUserId(userId);
        }

        public async Task<int> UpdateUserAddressDetail(UserAddressDetail user)
        {
            return await userAddressDetailRepository.UpdateUserAddressDetail(user);
        }

        public async Task<int> UpdateUserAddressDetails(List<UserAddressDetail> userAddressDetails)
        {
            return await userAddressDetailRepository.UpdateUserAddressDetails(userAddressDetails);
        }
    }
}
