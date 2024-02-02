using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Writers;
using System.ComponentModel.Design;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CompanyAddressBussinessLogic : ICompanyAddressBussinessLogic
    {
        private readonly ICompanyAddressRepository companyAddressRepo;
        public CompanyAddressBussinessLogic(ICompanyAddressRepository companyAddressRepo)
        {
            this.companyAddressRepo = companyAddressRepo;
        }

        //This method used to Delete Company Address based on companyAddressId
        public async Task<int> DeleteCompanyAddress(int companyAddressId)
        {
            return await companyAddressRepo.DeleteCompanyAddress(companyAddressId);
        }

        //This method used to Get Company Address based on CompanyAddressId
        public async Task<CompanyAddress> GetCompanyAddressByCompanyAddressId(int companyAddressId)
        {
            return await companyAddressRepo.GetCompanyAddressByCompanyAddressId(companyAddressId);
        }

        //This method used for Get CompanyAddresses 
        public async Task<List<CompanyAddress>> GetCompanyAddresses()
        {
            return await companyAddressRepo.GetCompanyAddresses();
        }

        //This method used for Add CompanyAddress based on the companyAddress
        public async Task<int> AddCompanyAddress(CompanyAddress companyAddress)
        {
            return await companyAddressRepo.AddCompanyAddress(companyAddress);
        }

        //This method used for Update CompanyAddress based on the CompanyAddress
        public async Task<bool> UpdateCompanyAddress(CompanyAddress companyAddress)
        {
            return await companyAddressRepo.UpdateCompanyAddress(companyAddress);
        }

        //This method used for Get Company Addresses based on CompanyId
        public async Task<List<CompanyAddress>> GetCompanyAddressesIdByCompanyId(int companyId)
        {
            return await companyAddressRepo.GetCompanyAddressesIdByCompanyId(companyId);

        }

        public async Task<int> DeleteRangeCompanyAddress(List<int> companyAddressIds)
        {
            return await companyAddressRepo.DeleteRangeCompanyAddress(companyAddressIds);
        }

        public async Task<List<int>> AddRangeCompanyAddress(List<CompanyAddress> companyAddresses)
        {
            return await AddRangeCompanyAddress(companyAddresses);
        }

        public async Task<bool> UpdateRangeCompanyAddress(List<CompanyAddress> companyAddresses)
        {
            return await UpdateRangeCompanyAddress(companyAddresses);
        }
    }
}
