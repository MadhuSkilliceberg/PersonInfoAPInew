using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IUserAddressDetailRepository
    {
        public Task<List<UserAddressDetail>> GetUserAddressDetails();

        public Task<List<UserAddressDetail>> GetUserAddressDetailsByUserId(int userId);


        public Task<int> AddUserAddressDetail(UserAddressDetail userAddressDetail);

        public Task<int> AddUserAddressDetails(List<UserAddressDetail> userAddressDetails);

        public Task<int> UpdateUserAddressDetail(UserAddressDetail user);

        public Task<int> UpdateUserAddressDetails(List<UserAddressDetail> userAddressDetails);

        public Task<int> DeleteUserAddressDetailById(int id);

        public Task<UserAddressDetail> GetUserAddressDetailsById(int id);

    }
}
