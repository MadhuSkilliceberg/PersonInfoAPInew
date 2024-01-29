using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class RoleRepository : IRoleRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteRole(int id)
        {
            var a = person.Roles.Where(c => c.Id == id).FirstOrDefault();
            person.Roles.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Role GetByRoleId(int id)
        {
            return person.Roles.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Role> GetRoles()
        {
            return person.Roles.ToList();
        }

        public int InsertRole(Role Role)
        {
            person.Roles.Add(Role);
            person.SaveChanges();
            return Role.Id;

        }

        public bool UpdateRole(Role Role)
        {
            person.Roles.Update(Role);
            person.SaveChanges();
            return true;
        }
    }
}
