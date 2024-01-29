using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class MediumRepo : IMediumRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

       

        public int DeleteUser(int id)
        {
            var k = Context.Media.Where(a => a.Id==id).FirstOrDefault();
            Context.Media.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Medium GetByUserId(int id)
        {
            var k = Context.Media.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public Medium GetByUserName(string mediumName)
        {
            var k = Context.Media.Where(a => a.Name == mediumName).FirstOrDefault();
            return k;
        }

        public List<Medium> GetUsers()
        {
            return Context.Media.ToList();
        }

        public bool InsertUser(Medium user)
        {
            Context.Media.Add(user);
            Context.SaveChanges();
            return true;
        }

        public bool UpdateUser(Medium user)
        {
            Context.Media.Update(user);
            Context.SaveChanges();
            return true;
        }
    }
}
