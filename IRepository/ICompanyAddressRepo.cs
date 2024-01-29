using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface ICompanyAddressRepo
    {
        public List<CompanyAddress> GetCompanyAddresss();
        public int InsertCompanyAddress(CompanyAddress companyAddress);

        public bool UpdateCompanyAddress(CompanyAddress companyAddress);

        public int DeleteCompanyAddress(int id);

        public CompanyAddress GetByCompanyAddressId(int id);
        public List<CompanyAddress> GetCompanyAddressIdByCompanyId(int companyid);

        public List<int> AddCompanyAddress(List<CompanyAddress> companyAddresses);

    }
}
