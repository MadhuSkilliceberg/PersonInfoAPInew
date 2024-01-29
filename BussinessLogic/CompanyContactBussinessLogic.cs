using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CompanyContactBussinessLogic: ICompanyContactBussinessLogic
    {
        ICompanyContactRepo userRepository;
        public CompanyContactBussinessLogic(ICompanyContactRepo Repo)
        {
            userRepository = Repo;
        }

        public int DeleteCompanyContact(int id)
        {
            return userRepository.DeleteCompanyContact(id);
        }

       
        public List<CompanyContact> GetCompanyContacts()
        {
            return userRepository.GetCompanyContacts();
        }

        public int InsertCompanyContact(CompanyContact companyContact)
        {
            return userRepository.InsertCompanyContact(companyContact);
        }

        public bool UpdateCompanyContact(CompanyContact companyContact)
        {
            return userRepository.UpdateCompanyContact(companyContact);
        }

        public List<CompanyContact> GetCompanyContactsByCompanyAddressId(int companyaddressId)
        {
            return userRepository.GetCompanyContactsByCompanyAddressId(companyaddressId);
        }

        public CompanyContact GetCompanyContactsById(int id)
        {
            return userRepository.GetCompanyContactsById(id);
        }
    }
}
