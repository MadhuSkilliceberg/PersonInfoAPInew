using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class RoleCategoryRepository : IRoleCategoryRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteRoleCategory(int id)
        {
            var a = person.RoleCategories.Where(c => c.Id == id).FirstOrDefault();
            person.RoleCategories.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public RoleCategory GetByRoleCategoryId(int id)
        {
            return person.RoleCategories.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<RoleCategory> GetRoleCategorys()
        {
            return person.RoleCategories.ToList();
        }

        public int InsertRoleCategory(RoleCategory RoleCategory)
        {
            person.RoleCategories.Add(RoleCategory);
            person.SaveChanges();
            return RoleCategory.Id;

        }

        public bool UpdateRoleCategory(RoleCategory RoleCategory)
        {
            person.RoleCategories.Update(RoleCategory);
            person.SaveChanges();
            return true;
        }
    }
}
