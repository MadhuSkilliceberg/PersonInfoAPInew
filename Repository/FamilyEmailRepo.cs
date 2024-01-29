using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{

    public class FamilyEmailRepo : IFamilyEmailRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteFamilyEmail(int id)
        {
            var k = Context.FamilyEmails.Where(a => a.Id == id).FirstOrDefault();
            Context.FamilyEmails.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public FamilyEmail GetById(int id)
        {
            var k = Context.FamilyEmails.Where(a => a.Id == id).FirstOrDefault();
            Context.FamilyEmails.Remove(k);
            Context.SaveChanges();
            return k;
        }

        public List<FamilyEmail> GetFamilyEmails()
        {
            return Context.FamilyEmails.ToList();
        }

        public int InsertFamilyEmail(FamilyEmail email)
        {
            Context.FamilyEmails.Add(email);
            Context.SaveChanges();
            return email.Id;
        }

        public int UpdateFamilyEmail(FamilyEmail email)
        {
            Context.FamilyEmails.Update(email);
            Context.SaveChanges();
            return email.Id;

        }
    }
}
