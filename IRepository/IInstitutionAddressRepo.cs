using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
  public  interface IInstitutionAddressRepo
    {
        public List<InstitutionAddress> GetInstitutionAddress();
        public int InsertInstitutionAddress(InstitutionAddress institutionAddress);

        public int UpdateinstitutionAddress(InstitutionAddress institutionAddress);

        public int DeleteInstitutionAddress(int id);

        public InstitutionAddress GetByInstitutionAddressId(int id);

        public bool AddinstitutionAddressDetails(List<InstitutionAddress> institutionAddresses);

        public List<InstitutionAddress> GetInstitutionAddressByInstituteId(int instituteId);


        public bool UpdateinstitutionAddressDetails(List<InstitutionAddress> institutionAddresses);

        public bool DeleteinstitutionAddressDetails(List<InstitutionAddress> institutionAddresses);


    }
}
