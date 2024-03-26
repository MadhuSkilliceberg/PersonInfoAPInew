using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
  public  interface ISkillRepo
    {
        public List<Skill> GetSkills();
        public int InsertSkill(Skill user);

        public int UpdateSkill(Skill user);

        public int DeleteSkill(int id);

        public Skill GetSkillById(int id);
    }
}
