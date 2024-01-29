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
        ICompanyEmailRepo userRepository;
        public CompanyEmailBussinessLogic(ICompanyEmailRepo Repo)
        {
            userRepository = Repo;
        }



        public CompanyEmail GetCompanyEmailById(int id)
        {
           return userRepository.GetCompanyEmailById(id);    
        }
        public int DeleteCompanyEmail(int id)
        {
            return userRepository.DeleteCompanyEmail(id);
        }

        public List<CompanyEmail> GetCompanyEmailByCompanyAddressId(int companyaddressId)
        {
           return userRepository.GetCompanyEmailByCompanyAddressId(companyaddressId);
        }

        public List<CompanyEmail> GetCompanyEmails()
        {
            return userRepository.GetCompanyEmails();
        }

        public int InsertCompanyEmail(CompanyEmail companyEmail)
        {
            return userRepository.InsertCompanyEmail(companyEmail);
        }

        public bool UpdateCompanyEmail(CompanyEmail companyEmail)
        {
            return userRepository.UpdateCompanyEmail(companyEmail);
        }
    }
}
