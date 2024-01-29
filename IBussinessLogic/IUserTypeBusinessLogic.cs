using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IUserTypeBusinessLogic
    {
        public List<UserType> GetUserTypes();
        public bool InsertUserType(UserType UserType);

        public bool UpdateUserType(UserType UserType);

        public int DeleteUserType(int id);

        public UserType GetByUserTypeId(int id);

    }
}
