using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
    public interface IInstitutionAddressBusinessLogic
    {
        public List<InstitutionAddress> GetInstitutionAddresss();
        public int InsertInstitutionAddress(InstitutionAddress institutionAddress);

        public int UpdateInstitutionAddress(InstitutionAddress institutionAddress);

        public int DeleteInstitutionAddress(int id);

        public InstitutionAddress GetByInstitutionAddressId(int id);
        public List<InstitutionAddresslist> GetInstitutionAddresslist();

        public List<InstitutionAddress> GetInstitutionAddressByInstituteId(int instituteId);






    }
}
