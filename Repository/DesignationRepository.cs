using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class DesignationRepository : IDesignationRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();
        public int DeleteUser(int id)
        {
            var k = Context.Designations.Where(a => a.Id == id).FirstOrDefault();
            Context.Designations.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Designation GetByUserId(int id)
        {

            var k = Context.Designations.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<Designation> GetUsers()
        {
            return Context.Designations.ToList();
        }

        public int InsertUser(Designation user)
        {
            Context.Designations.Add(user);
            Context.SaveChanges();
            return user.Id;
        }

        public int UpdateUser(Designation user)
        {
            Context.Designations.Update(user);
            Context.SaveChanges();
            return user.Id;
        }
    }
}
