using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class VacanciesSkillRepository : IVacanciesSkillRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteVacanciesSkill(int id)
        {
            var a = person.VacanciesSkills.Where(c => c.Id == id).FirstOrDefault();
            person.VacanciesSkills.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public VacanciesSkill GetByVacanciesSkillId(int id)
        {
            return person.VacanciesSkills.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<VacanciesSkill> GetVacanciesSkills()
        {
            return person.VacanciesSkills.ToList();
        }

        public int InsertVacanciesSkill(VacanciesSkill VacanciesSkill)
        {
            person.VacanciesSkills.Add(VacanciesSkill);
            person.SaveChanges();
            return VacanciesSkill.Id;

        }

        public bool UpdateVacanciesSkill(VacanciesSkill VacanciesSkill)
        {
            person.VacanciesSkills.Update(VacanciesSkill);
            person.SaveChanges();
            return true;
        }
    }
}
