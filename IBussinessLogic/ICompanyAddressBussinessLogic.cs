using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
   public interface ICompanyAddressBussinessLogic
    {
        //This method used for Get CompanyAddresses 
        public Task<List<CompanyAddress>> GetCompanyAddresses();

        //This method used for Add CompanyAddress based on the companyAddress
        public Task<int> AddCompanyAddress(CompanyAddress companyAddress);

        //This method used for Update CompanyAddress based on the CompanyAddress
        public Task<bool> UpdateCompanyAddress(CompanyAddress companyAddress);

        //This method used to Delete Company Address based on companyAddressId
        public Task<int> DeleteCompanyAddress(int companyAddressId);

        //This method used to Delete Company Address based on companyAddressId
        public Task<int> DeleteRangeCompanyAddress(List<int> companyAddressIds);

        //This method used to Get Company Address based on CompanyAddressId
        public Task<CompanyAddress> GetCompanyAddressByCompanyAddressId(int companyAddressId);

        //This method used for Get Company Addresses based on CompanyId
        public Task<List<CompanyAddress>> GetCompanyAddressesIdByCompanyId(int companyId);

        //This mmethod used for Add CompanyAddresses based on ther CompanyAddresses
        public Task<List<int>> AddRangeCompanyAddress(List<CompanyAddress> companyAddresses);

        //This method used for Update CompanyAddress based on the CompanyAddresses
        public Task<bool> UpdateRangeCompanyAddress(List<CompanyAddress> companyAddresses);
    }
}
