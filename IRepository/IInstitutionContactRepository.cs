using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IInstitutionContactRepository
    {
        public Task<List<InstitutionContact>> GetInstitutionContacts();
        public Task<int> AddInstitutionContact(InstitutionContact institutionContact);

        public Task<int> UpdateInstitutionContact(InstitutionContact institutionContact);

        public Task<int> DeleteInstitutionContactByInstitutionContactId(int institutionContactId);

        public Task<InstitutionContact> GetInstitutionContactByInstitutionContactId(int institutionContactId);

        public Task<bool> AddRangeInstitutionContacts(List<InstitutionContact> institutionContacts);
        public Task<List<InstitutionContact>> GetInstitutionContactsByAddressId(int addressId);


        public Task<bool> UpdateRangeInstitutionContacts(List<InstitutionContact> institutionContacts);

        public Task<bool> DeleteRangeInstitutionContacts(List<InstitutionContact> institutionContacts);
    }
}
