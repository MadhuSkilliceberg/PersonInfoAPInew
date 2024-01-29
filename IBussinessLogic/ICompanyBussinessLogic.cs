using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
   public interface ICompanyBussinessLogic
    {
        public List<Company> GetCompanys();
        public int InsertCompany(Company company);

        public int UpdateCompany(Company company);

        public int DeleteCompany(int id);

        public Company GetByCompanyId(int id);
        public bool AddCompanyTables(CompanyModels companyModels);

        public bool AddCompanyDetail(CompanyDetail companyDetail); 

    }
}
