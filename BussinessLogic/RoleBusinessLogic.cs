using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class RoleBusinessLogic: IRoleBusinessLogic
    {
        IRoleRepo RoleRepo;

        public  RoleBusinessLogic(IRoleRepo Repo)
        {
            RoleRepo = Repo;
        }

        public int DeleteRole(int id)
        {
            return RoleRepo.DeleteRole(id);
        }

        public Role GetByRoleId(int id)
        {
            return RoleRepo.GetByRoleId(id);
        }

        public List<Role> GetRoles()
        {
            return RoleRepo.GetRoles();
        }

        public int InsertRole(Role Role)
        {
            return RoleRepo.InsertRole(Role);
        }

        public bool UpdateRole(Role Role)
        {
            return RoleRepo.UpdateRole(Role);
        }
    }
}
