using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class SkillRepo: ISkillRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteUser(int id)
        {
            var k = Context.Skills.Where(a => a.Id == id).FirstOrDefault();
            Context.Skills.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Skill GetByUserId(int id)
        {
            var k = Context.Skills.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<Skill> GetUsers()
        {
            return Context.Skills.ToList();
        }

        public int InsertUser(Skill user)
        {
            Context.Skills.Add(user);
            Context.SaveChanges();
            return user.Id;
        }

        public int UpdateUser(Skill user)
        {
            Context.Skills.Update(user);
            Context.SaveChanges();
            return user.Id;
        }
    }
}
