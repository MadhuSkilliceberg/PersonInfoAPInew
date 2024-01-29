using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
 public   interface ICompanyContactBussinessLogic
    {
        public List<CompanyContact> GetCompanyContacts();
        public int InsertCompanyContact(CompanyContact companyContact);

        public bool UpdateCompanyContact(CompanyContact companyContact);

        public int DeleteCompanyContact(int id);

        public List<CompanyContact> GetCompanyContactsByCompanyAddressId(int companyaddressId);
        public CompanyContact GetCompanyContactsById(int id);

    }
}
