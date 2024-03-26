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

        public int DeleteSkill(int id)
        {
            var k = Context.Skills.Where(a => a.Id == id).FirstOrDefault();
            Context.Skills.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Skill GetSkillById(int id)
        {
            var k = Context.Skills.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<Skill> GetSkills()
        {
            return Context.Skills.ToList();
        }

        public int InsertSkill(Skill user)
        {
            Context.Skills.Add(user);
            Context.SaveChanges();
            return user.Id;
        }

        public int UpdateSkill(Skill user)
        {
            Context.Skills.Update(user);
            Context.SaveChanges();
            return user.Id;
        }
    }
}
