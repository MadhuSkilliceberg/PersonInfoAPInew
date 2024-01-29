using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class FamilyRepository : IFamilyRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public bool DeleteFamily(int id)
        {
            var k = Context.Families.Where(a => a.Id == id).FirstOrDefault();

            Context.Families.Remove(k);
            Context.SaveChanges();
            return true;
        }

        public Family GetById(int id)
        {
            var k = Context.Families.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<Family> GetFamilies()
        {
           return Context.Families.ToList();
        }

        public bool InsertFamily(Family family)
        {
            Context.Families.Add(family);
            Context.SaveChanges();
            return true;
        }

        public bool UpdateFamily(Family family)
        {
            Context.Families.Update(family);
            Context.SaveChanges();
            return true;
        }
    }
}
