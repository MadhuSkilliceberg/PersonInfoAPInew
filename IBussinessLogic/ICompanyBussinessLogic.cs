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
        public Task<List<Company>> GetCompanies();
        public Task<int> AddCompany(Company company);
        public Task<int> AddRangeCompany(List<Company> companies);
        public Task<int> UpdateCompany(Company company);
        public Task<int> UpdateRangeCompany(List<Company> companies);
        public Task<bool> DeleteCompany(int id);
        public Task<bool> DeleteRangeCompany(List<int> ids);
        public Task<Company> GetCompanyById(int id);
        public Task<bool> AddCompanyDetail(CompanyDetail companyDetail);
        public Task<bool> AddCompanyTables(CompanyModels companyModels);
    }
}
