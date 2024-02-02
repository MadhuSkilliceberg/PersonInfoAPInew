using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CompanyContactBussinessLogic : ICompanyContactBussinessLogic
    {
        private readonly ICompanyContactRepository companyContactRepository;

        public CompanyContactBussinessLogic(ICompanyContactRepository companyContactRepository)
        {
            this.companyContactRepository = companyContactRepository;
        }
        public async Task<List<CompanyContact>> GetCompanyContacts()
        {
            return await companyContactRepository.GetCompanyContacts();
        }

        public async Task<CompanyContact> GetCompanyContactById(int id)
        {
            return await companyContactRepository.GetCompanyContactById(id);
        }

        public async Task<int> AddCompanyContact(CompanyContact companyContact)
        {
            return await companyContactRepository.AddCompanyContact(companyContact);
        }

        public async Task<int> AddRangeCompanyContact(List<CompanyContact> companyContacts)
        {
            return await companyContactRepository.AddRangeCompanyContact(companyContacts);
        }

        async Task<int> ICompanyContactBussinessLogic.UpdateCompanyContact(CompanyContact companyContact)
        {
            return await companyContactRepository.UpdateCompanyContact(companyContact);
        }

        public async Task<int> UpdateRangeCompanyContact(List<CompanyContact> companyContacts)
        {
            return await companyContactRepository.UpdateRangeCompanyContact(companyContacts);
        }

        async Task<bool> ICompanyContactBussinessLogic.DeleteCompanyContact(int id)
        {
            return await companyContactRepository.DeleteCompanyContact(id);
        }

        public async Task<bool> DeleteRangeCompanyContact(List<int> ids)
        {
            return await companyContactRepository.DeleteRangeCompanyContact(ids);
        }

        async Task<List<CompanyContact>> ICompanyContactBussinessLogic.GetCompanyContactByCompanyAddressId(int companyaddressId)
        {
            return await companyContactRepository.GetCompanyContactByCompanyAddressId(companyaddressId);
        }
    }
}
