using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ICompanyContactRepository
    {
        public Task<List<CompanyContact>> GetCompanyContacts();
        public Task<CompanyContact> GetCompanyContactById(int id);
        public Task<int> AddCompanyContact(CompanyContact companyContact);
        public Task<int> AddRangeCompanyContact(List<CompanyContact> companyContacts);
        public Task<int> UpdateCompanyContact(CompanyContact companyContact);
        public Task<int> UpdateRangeCompanyContact(List<CompanyContact> companyContacts);
        public Task<bool> DeleteCompanyContact(int id);
        public Task<bool> DeleteRangeCompanyContact(List<int> ids);
        public Task<List<CompanyContact>> GetCompanyContactByCompanyAddressId(int companyaddressId);

    }
}
