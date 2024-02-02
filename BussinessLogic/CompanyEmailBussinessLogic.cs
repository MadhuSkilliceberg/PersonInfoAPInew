using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CompanyEmailBussinessLogic : ICompanyEmailBussinessLogic
    {
        private readonly ICompanyEmailRepository companyEmailRepository;

        public CompanyEmailBussinessLogic(ICompanyEmailRepository companyEmailRepository)
        {
            this.companyEmailRepository = companyEmailRepository;
        }

        public async Task<int> AddCompanyEmail(CompanyEmail companyEmail)
        {
            return await companyEmailRepository.AddCompanyEmail(companyEmail);
        }

        public async Task<int> AddRangeCompanyEmail(List<CompanyEmail> companyEmails)
        {
            return await companyEmailRepository.AddRangeCompanyEmail(companyEmails);
        }

        public async Task<int> DeleteCompanyEmail(int id)
        {
            return await companyEmailRepository.DeleteCompanyEmail(id);
        }

        public async Task<int> DeleteRangeCompanyEmail(List<int> ids)
        {
            return await companyEmailRepository.DeleteRangeCompanyEmail(ids);
        }

        public async Task<List<CompanyEmail>> GetCompanyEmailByCompanyAddressId(int companyaddressId)
        {
            return await companyEmailRepository.GetCompanyEmailByCompanyAddressId(companyaddressId);
        }

        public async Task<CompanyEmail> GetCompanyEmailById(int id)
        {
            return await companyEmailRepository.GetCompanyEmailById(id);
        }

        public async Task<List<CompanyEmail>> GetCompanyEmails()
        {
            return await companyEmailRepository.GetCompanyEmails();
        }

        public async Task<int> UpdateCompanyEmail(CompanyEmail companyEmail)
        {
            return await companyEmailRepository.UpdateCompanyEmail(companyEmail);
        }

        public async Task<int> UpdateRangeCompanyEmail(List<CompanyEmail> companyEmails)
        {
            return await companyEmailRepository.UpdateRangeCompanyEmail(companyEmails);
        }
    }
}
