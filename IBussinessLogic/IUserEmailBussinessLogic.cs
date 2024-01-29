using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IUserEmailBussinessLogic
    {
        public List<UserEmail> GetUsers();
        public bool InsertUser(UserEmail user);

        public bool UpdateUser(UserEmail user);

        public int DeleteUser(int id);

        public UserEmail GetByUserId(int id);
    }
}
