using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class RoleCategoryBusinessLogic: IRoleCategoryBusinessLogic
    {
        IRoleCategoryRepo RoleCategoryRepo;

        public  RoleCategoryBusinessLogic(IRoleCategoryRepo Repo)
        {
            RoleCategoryRepo = Repo;
        }

        public int DeleteRoleCategory(int id)
        {
            return RoleCategoryRepo.DeleteRoleCategory(id);
        }

        public RoleCategory GetByRoleCategoryId(int id)
        {
            return RoleCategoryRepo.GetByRoleCategoryId(id);
        }

        public List<RoleCategory> GetRoleCategorys()
        {
            return RoleCategoryRepo.GetRoleCategorys();
        }

        public int InsertRoleCategory(RoleCategory RoleCategory)
        {
            return RoleCategoryRepo.InsertRoleCategory(RoleCategory);
        }

        public bool UpdateRoleCategory(RoleCategory RoleCategory)
        {
            return RoleCategoryRepo.UpdateRoleCategory(RoleCategory);
        }
    }
}
