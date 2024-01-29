using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IRoleBusinessLogic
    {
        public List<Role> GetRoles();
        public int InsertRole(Role Role);

        public bool UpdateRole(Role Role);

        public int DeleteRole(int id);

        public Role GetByRoleId(int id);

    }
}
