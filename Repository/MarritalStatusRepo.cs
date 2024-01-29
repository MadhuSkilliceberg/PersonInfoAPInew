using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class MarritalStatusRepo: IMarritalStatusRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteUser(int id)
        {
            var k = Context.MarritalStatuses.Where(a => a.Id == id).FirstOrDefault();
            Context.MarritalStatuses.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public MarritalStatus GetByUserId(int id)
        {
            var k = Context.MarritalStatuses.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<MarritalStatus> GetUsers()
        {
            return Context.MarritalStatuses.ToList();
        }

        public bool InsertUser(MarritalStatus user)
        {
            Context.MarritalStatuses.Add(user);
            Context.SaveChanges();
            return true;
        }

        public bool UpdateUser(MarritalStatus user)
        {
            Context.MarritalStatuses.Update(user);
            Context.SaveChanges();
            return true;
        }
    }
}
