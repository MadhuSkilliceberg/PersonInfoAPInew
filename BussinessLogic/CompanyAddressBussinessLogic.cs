using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CompanyAddressBussinessLogic: ICompanyAddressBussinessLogic
    {
        ICompanyAddressRepo userRepository;
        public CompanyAddressBussinessLogic(ICompanyAddressRepo Repo)
        {
            userRepository = Repo;
        }

        public int DeleteCompanyAddress(int id)
        {
            return userRepository.DeleteCompanyAddress(id);
        }

        public CompanyAddress GetByCompanyAddressId(int id)
        {
            return userRepository.GetByCompanyAddressId(id);
        }

        public List<CompanyAddress> GetCompanyAddresss()
        {
            return userRepository.GetCompanyAddresss();
        }

        public int InsertCompanyAddress(CompanyAddress companyAddress)
        {
            return userRepository.InsertCompanyAddress(companyAddress);
        }

        public bool UpdateCompanyAddress(CompanyAddress companyAddress)
        {
            return userRepository.UpdateCompanyAddress(companyAddress);
        }

        public List<CompanyAddress> GetCompanyAddressIdByCompanyId(int companyid)
        {
            return userRepository.GetCompanyAddressIdByCompanyId(companyid);
             
        }

    }
}
