using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ICompanyEmailBussinessLogic
    {
        public List<CompanyEmail> GetCompanyEmails();
        public CompanyEmail GetCompanyEmailById(int id);

        public int InsertCompanyEmail(CompanyEmail companyEmail);

        public bool UpdateCompanyEmail(CompanyEmail companyEmail);

        public int DeleteCompanyEmail(int id);

        public List<CompanyEmail> GetCompanyEmailByCompanyAddressId(int companyaddressId);

    }
}
