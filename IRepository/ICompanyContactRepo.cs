using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ICompanyContactRepo
    {
        public List<CompanyContact> GetCompanyContacts();
        public CompanyContact GetCompanyContactsById(int id);
        public int InsertCompanyContact(CompanyContact companyContact);

        public bool UpdateCompanyContact(CompanyContact companyContact);

        public int DeleteCompanyContact(int id);
        public bool AddCompanyContact(List<CompanyContact> companyContacts);

        public List<CompanyContact> GetCompanyContactsByCompanyAddressId(int companyaddressId);

    }
}
