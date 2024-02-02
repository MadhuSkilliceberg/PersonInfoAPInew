using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
  public  interface IInstitutionAddressRepository
    {
        public Task<List<InstitutionAddress>> GetInstitutionAddresses();
        public Task<int> AddInstitutionAddress(InstitutionAddress institutionAddress);

        public Task<int> UpdateInstitutionAddress(InstitutionAddress institutionAddress);

        public Task<int> DeleteInstitutionAddressByInstitutionId(int institutionAdressId);

        public Task<InstitutionAddress> GetInstitutionAddressByInstitutionAdressId(int institutionAdressId);

        public Task<bool> AddRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses);

        public Task<List<InstitutionAddress>> GetInstitutionAddressByInstituteId(int instituteId);


        public Task<bool> UpdateRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses);

        public Task<bool> DeleteRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses);


    }
}
