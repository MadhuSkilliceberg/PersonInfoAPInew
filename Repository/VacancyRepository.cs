using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class VacancyRepository : IVacancyRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteVacancy(int id)
        {
            var a = person.Vacancies.Where(c => c.Id == id).FirstOrDefault();
            person.Vacancies.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Vacancy GetByVacancyId(int id)
        {
            return person.Vacancies.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Vacancy> GetVacancys()
        {
            return person.Vacancies.ToList();
        }

        public int InsertVacancy(Vacancy Vacancy)
        {
            person.Vacancies.Add(Vacancy);
            person.SaveChanges();
            return Vacancy.Id;

        }

        public bool UpdateVacancy(Vacancy Vacancy)
        {
            person.Vacancies.Update(Vacancy);
            person.SaveChanges();
            return true;
        }
    }
}
