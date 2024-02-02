using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Repository;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class InstitutionContactBussinessLogic : IInstitutionContactBussinessLogic
    {
        private readonly IInstitutionContactRepository _institutionContactRepository;
        private readonly IInstitutionAddressRepository _institutionAddressRepository;
        public InstitutionContactBussinessLogic(IInstitutionContactRepository institutionContactRepository, IInstitutionAddressRepository institutionAddressRepository)
        {
            _institutionAddressRepository = institutionAddressRepository;
            _institutionContactRepository = institutionContactRepository;
        }

        public async Task<int> DeleteInstitutionContactByInstitutionContactId(int institutionContactId)

        {
            return await _institutionContactRepository.DeleteInstitutionContactByInstitutionContactId(institutionContactId);
        }

        public async Task<InstitutionContact> GetInstitutionContactByInstitutionContactId(int institutionContactId)

        {
            return await _institutionContactRepository.GetInstitutionContactByInstitutionContactId(institutionContactId);
        }

        public async Task<List<InstitutionContact>> GetInstitutionContacts()

        {
            return await _institutionContactRepository.GetInstitutionContacts();
        }

        public async Task<int> AddInstitutionContact(InstitutionContact institutionContact)

        {
            return await _institutionContactRepository.AddInstitutionContact(institutionContact);
        }

        public async Task<int> UpdateInstitutionContact(InstitutionContact institutionContact)

        {
            return await _institutionContactRepository.UpdateInstitutionContact(institutionContact);
        }

        public async Task<List<InstitutionContactList>> GetInstitutionContactList()
        {
            var institutionEmail = await _institutionContactRepository.GetInstitutionContacts();
            var institutioncontsct = await _institutionAddressRepository.GetInstitutionAddresses();

            var data = from i in institutionEmail
                       join
                       inaddress in institutioncontsct on
                       i.InstitutionAddressId equals inaddress.Id

                       select new InstitutionContactList
                       {
                           Id = i.Id,
                           Address1 = inaddress.Address1,
                           MobileNumber = i.MobileNumber,
                           IsPrimary = i.IsPrimary,
                           OrderId = i.OrderId,

                       };
            return data.ToList();


        }

        public async Task<List<InstitutionContact>> GetInstitutionContactsByAddressId(int addressId)

        {
            return await _institutionContactRepository.GetInstitutionContactsByAddressId(addressId);
        }


        public async Task<bool> AddRangeInstitutionContacts(List<InstitutionContact> institutionContacts)

        {

            return await _institutionContactRepository.AddRangeInstitutionContacts(institutionContacts);

        }
        public async Task<bool> UpdateRangeInstitutionContacts(List<InstitutionContact> institutionContacts)
        {
            return await _institutionContactRepository.UpdateRangeInstitutionContacts(institutionContacts);
        }

        public async Task<bool> DeleteRangeInstitutionContacts(List<InstitutionContact> institutionContacts)
        {
            return await _institutionContactRepository.DeleteRangeInstitutionContacts(institutionContacts);

        }

    }
}
