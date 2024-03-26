using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class SkillBussinessLogic : ISkillBussinessLogic
    {
        ISkillRepo skillRepository;
        public SkillBussinessLogic(ISkillRepo Repo)
        {
            skillRepository = Repo;
        }

        public int DeleteSkill(int id)
        {
            return skillRepository.DeleteSkill(id);
        }

        public Skill GetSkillById(int id)
        {

            return skillRepository.GetSkillById(id);
        }

        public List<Skill> GetSkills()
        {
            return skillRepository.GetSkills();
        }

        public int InsertSkill(Skill Skill)
        {
            return skillRepository.InsertSkill(Skill);
        }

        public int UpdateSkill(Skill Skill)
        {
            return skillRepository.UpdateSkill(Skill);

        }




    }
}
