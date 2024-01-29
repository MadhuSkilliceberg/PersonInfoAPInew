using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IRoleCategoryBusinessLogic
    {
        public List<RoleCategory> GetRoleCategorys();
        public int InsertRoleCategory(RoleCategory RoleCategory);

        public bool UpdateRoleCategory(RoleCategory RoleCategory);

        public int DeleteRoleCategory(int id);

        public RoleCategory GetByRoleCategoryId(int id);

    }
}
