using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IVacancyBusinessLogic
    {
        public List<Vacancy> GetVacancys();
        public int InsertVacancy(Vacancy Vacancy);

        public bool UpdateVacancy(Vacancy Vacancy);

        public int DeleteVacancy(int id);

        public Vacancy GetByVacancyId(int id);

    }
}
