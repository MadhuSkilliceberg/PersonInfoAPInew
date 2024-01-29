using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IInstitutionEmailBussinessLogic
    {
        public List<InstitutionEmail> GetInstitutionEmails();
        public int InsertInstitutionEmail(InstitutionEmail institutionEmail);

        public int UpdateInstitutionEmail(InstitutionEmail institutionEmail);

        public int DeleteInstitutionEmail(int id);

        public InstitutionEmail GetByInstitutionEmailId(int id);
        public List<InstitutionEmailList> GetInstitutionEmailList();
        public List<InstitutionEmail> GetInstitutionEmailsByAddressId(int addressId);
       
    }
}
 