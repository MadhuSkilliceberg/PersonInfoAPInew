using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ISkillBussinessLogic
    {
        public List<Skill> GetUsers();
        public int InsertUser(Skill user);

        public int UpdateUser(Skill user);

        public int DeleteUser(int id);

        public Skill GetByUserId(int id);
    }
}
