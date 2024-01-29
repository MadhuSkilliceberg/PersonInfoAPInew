using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class FamilyContactRepository : IFamilyContactRepo

    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public int DeleteUser(int id)
        {
            var k = Context.FamilyContacts.Where(a => a.Id == id).FirstOrDefault();
            Context.FamilyContacts.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public FamilyContact GetByUserId(int id)
        {
            var k = Context.FamilyContacts.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<FamilyContact> GetUsers()
        {
            return Context.FamilyContacts.ToList();
        }

        public bool InsertUser(FamilyContact user)
        {
            Context.FamilyContacts.Add(user);
            Context.SaveChanges();
            return true;
        }

        public bool UpdateUser(FamilyContact user)
        {
            Context.FamilyContacts.Update(user);
            Context.SaveChanges();
            return true;
        }
    }
}
