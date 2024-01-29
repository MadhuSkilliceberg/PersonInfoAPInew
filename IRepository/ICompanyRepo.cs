using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
  public  interface ICompanyRepo
    {
        public List<Company> GetCompany();
        public int InsertCompany(Company company);

        public int UpdateCompany(Company company);

        public int DeleteCompany(int id);

        public Company GetByCompanyId(int id);

    }
}
