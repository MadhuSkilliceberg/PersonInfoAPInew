using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IInstitutionContactRepo
    {
        public List<InstitutionContact> GetInstitutionContacts();
        public int InsertInstitutionContact(InstitutionContact institutionContact);

        public int UpdateInstitutionContact(InstitutionContact institutionContact);

        public int DeleteInstitutionContact(int id);

        public InstitutionContact GetByInstitutionContactId(int id);

        public bool AddinstitutionContactsDetails(List<InstitutionContact> institutionContacts);
        public List<InstitutionContact> GetInstitutionContactsByAddressId(int AddressId);


        public bool UpdateinstitutionContactsDetails(List<InstitutionContact> institutionContacts);

        public bool DeleteinstitutionContactsDetails(List<InstitutionContact> institutionContacts);
    }
}
