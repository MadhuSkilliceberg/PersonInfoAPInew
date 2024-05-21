using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ISkillBussinessLogic
    {
        public List<Skill> GetSkills();
        public int InsertSkill(Skill question);

        public int UpdateSkill(Skill question);

        public int DeleteSkill(int id);

        public Skill GetSkillById(int id);

        public List<Skill> GetSkillsSearch(string name);
    }
}
