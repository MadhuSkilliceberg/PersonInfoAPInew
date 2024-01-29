using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class StateRepo : IStateRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteUser(int id)
        {
            var k = Context.States.Where(a => a.Id == id).FirstOrDefault();

            Context.States.Remove(k);
            Context.SaveChanges();
            return 1;
        }



        public State GetByUserId(int id)
        { 
            var k = Context.States.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<State> GetUsers()
        {
            return Context.States.ToList();
        }

        public bool InsertUser(State user)
        {
            Context.States.Add(user);
            Context.SaveChanges();
            return true;
        }

        public bool UpdateUser(State user)
        {
            Context.States.Update(user);
            Context.SaveChanges();
            return true;
        }

    

        
    }
}
