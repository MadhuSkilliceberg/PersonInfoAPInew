using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
 public   interface IStateBussinessLogic
    {
        public List<State> GetUsers();
        public bool InsertUser(State user);

        public bool UpdateUser(State user);

        public int DeleteUser(int id);

        public State GetByUserId(int id);

        public List<string> GetAllFamilyDetailsByPuttingUser(string username);
    }
}
