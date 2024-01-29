using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class GenderRepo: IGenderRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteUser(int id)
        {
            var k = Context.Genders.Where(a => a.Id == id).FirstOrDefault();
            Context.Genders.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Gender GetByUserId(int id)
        {
            var k = Context.Genders.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<Gender> GetUsers()
        {
            return Context.Genders.ToList();
        }

        public bool InsertUser(Gender user)
        {
            Context.Genders.Add(user);
            Context.SaveChanges();
            return true;
        }

        public bool UpdateUser(Gender user)
        {
            Context.Genders.Update(user);
            Context.SaveChanges();
            return true;
        }
    }
}
