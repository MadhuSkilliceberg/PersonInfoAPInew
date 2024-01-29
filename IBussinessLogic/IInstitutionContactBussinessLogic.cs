using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
 public   interface IInstitutionContactBussinessLogic
    {
        public List<InstitutionContact> GetInstitutionContacts();
        public int InsertInstitutionContact(InstitutionContact institutionContact);

        public int UpdateInstitutionContact(InstitutionContact institutionContact);

        public int DeleteInstitutionContact(int id);

        public InstitutionContact GetByInstitutionContactId(int id);
        public List<InstitutionContactList> GetInstitutionContactList();

        public List<InstitutionContact> GetInstitutionContactsByAddressId(int AddressId);
      

    }
}
