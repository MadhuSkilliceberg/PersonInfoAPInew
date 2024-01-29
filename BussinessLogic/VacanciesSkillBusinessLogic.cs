using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class VacanciesSkillBusinessLogic: IVacanciesSkillBusinessLogic
    {
        IVacanciesSkillRepo VacanciesSkillRepo;

        public  VacanciesSkillBusinessLogic(IVacanciesSkillRepo Repo)
        {
            VacanciesSkillRepo = Repo;
        }

        public int DeleteVacanciesSkill(int id)
        {
            return VacanciesSkillRepo.DeleteVacanciesSkill(id);
        }

        public VacanciesSkill GetByVacanciesSkillId(int id)
        {
            return VacanciesSkillRepo.GetByVacanciesSkillId(id);
        }

        public List<VacanciesSkill> GetVacanciesSkills()
        {
            return VacanciesSkillRepo.GetVacanciesSkills();
        }

        public int InsertVacanciesSkill(VacanciesSkill VacanciesSkill)
        {
            return VacanciesSkillRepo.InsertVacanciesSkill(VacanciesSkill);
        }

        public bool UpdateVacanciesSkill(VacanciesSkill VacanciesSkill)
        {
            return VacanciesSkillRepo.UpdateVacanciesSkill(VacanciesSkill);
        }
    }
}
