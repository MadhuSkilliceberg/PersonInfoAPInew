using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IVacanciesSkillBusinessLogic
    {
        public List<VacanciesSkill> GetVacanciesSkills();
        public int InsertVacanciesSkill(VacanciesSkill VacanciesSkill);

        public bool UpdateVacanciesSkill(VacanciesSkill VacanciesSkill);

        public int DeleteVacanciesSkill(int id);

        public VacanciesSkill GetByVacanciesSkillId(int id);

    }
}
