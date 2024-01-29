using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IUserAddressDetailBusinessLogic
    {
        public List<UserAddressDetail> GetUsers();
        public bool InsertUser(UserAddressDetail user);

        public bool UpdateUser(UserAddressDetail user);

        public int DeleteUser(int id);

        public UserAddressDetail GetByUserId(int id);

    }
}
