using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ICompanyEmailBussinessLogic
    {
        public Task<List<CompanyEmail>> GetCompanyEmails();
        public Task<CompanyEmail> GetCompanyEmailById(int id);
        public Task<int> AddCompanyEmail(CompanyEmail companyEmail);
        public Task<int> AddRangeCompanyEmail(List<CompanyEmail> companyEmails);
        public Task<int> UpdateCompanyEmail(CompanyEmail companyEmail);
        public Task<int> UpdateRangeCompanyEmail(List<CompanyEmail> companyEmails);
        public Task<int> DeleteCompanyEmail(int id);
        public Task<int> DeleteRangeCompanyEmail(List<int> ids);
        public Task<List<CompanyEmail>> GetCompanyEmailByCompanyAddressId(int companyaddressId);

    }
}
