using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class VacancyBusinessLogic: IVacancyBusinessLogic
    {
        IVacancyRepo VacancyRepo;

        public  VacancyBusinessLogic(IVacancyRepo Repo)
        {
            VacancyRepo = Repo;
        }

        public int DeleteVacancy(int id)
        {
            return VacancyRepo.DeleteVacancy(id);
        }

        public Vacancy GetByVacancyId(int id)
        {
            return VacancyRepo.GetByVacancyId(id);
        }

        public List<Vacancy> GetVacancys()
        {
            return VacancyRepo.GetVacancys();
        }

        public int InsertVacancy(Vacancy Vacancy)
        {
            return VacancyRepo.InsertVacancy(Vacancy);
        }

        public bool UpdateVacancy(Vacancy Vacancy)
        {
            return VacancyRepo.UpdateVacancy(Vacancy);
        }
    }
}
