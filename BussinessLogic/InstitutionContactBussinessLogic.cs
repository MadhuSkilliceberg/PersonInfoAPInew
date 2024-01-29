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
        IInstitutionContactRepo InstitutionContactRepository;
        IInstitutionAddressRepo institutionAddressRepo;
        public InstitutionContactBussinessLogic(IInstitutionContactRepo Repo, IInstitutionAddressRepo institutionAddressRepo)
        {
            InstitutionContactRepository = Repo;
            this.institutionAddressRepo = institutionAddressRepo;
        }

        public int DeleteInstitutionContact(int id)
        {
            return InstitutionContactRepository.DeleteInstitutionContact(id);
        }

        public InstitutionContact GetByInstitutionContactId(int id)
        {
            return InstitutionContactRepository.GetByInstitutionContactId(id);
        }

        public List<InstitutionContact> GetInstitutionContacts()
        {
            return InstitutionContactRepository.GetInstitutionContacts();
        }

        public int InsertInstitutionContact(InstitutionContact institutionContact)
        {
            return InstitutionContactRepository.InsertInstitutionContact(institutionContact);
        }

        public int UpdateInstitutionContact(InstitutionContact institutionContact)
        {
            return InstitutionContactRepository.UpdateInstitutionContact(institutionContact);
        }

        public List<InstitutionContactList> GetInstitutionContactList()
        {
            var institutionemail = InstitutionContactRepository.GetInstitutionContacts();
            var institutioncontsct = institutionAddressRepo.GetInstitutionAddress();

                        var data = from i in institutionemail
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

        public List<InstitutionContact> GetInstitutionContactsByAddressId(int AddressId)
        {
            return InstitutionContactRepository.GetInstitutionContactsByAddressId(AddressId);
        }
    }
}
