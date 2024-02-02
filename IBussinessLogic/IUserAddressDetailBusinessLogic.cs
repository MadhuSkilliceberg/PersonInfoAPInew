using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IUserAddressDetailBusinessLogic
    {
        public Task<List<UserAddressDetail>> GetUserAddressDetails();

        public Task<List<UserAddressDetail>> GetUserAddressDetailsByUserId(int userId);

        public Task<int> AddUserAddressDetail(UserAddressDetail userAddressDetail);

        public Task<int> AddUserAddressDetails(List<UserAddressDetail> userAddressDetails);

        public Task<int> UpdateUserAddressDetail(UserAddressDetail userAddressDetail);

        public Task<int> UpdateUserAddressDetails(List<UserAddressDetail> userAddressDetails);

        public Task<int> DeleteUserAddressDetailById(int id);

        public Task<UserAddressDetail> GetUserAddressDetailById(int id);

    }
}
