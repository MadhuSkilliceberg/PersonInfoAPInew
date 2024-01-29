using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class InstitutionEmailBussinessLogic: IInstitutionEmailBussinessLogic
    {
        IInstitutionEmailRepo InstitutionEmailRepository;
        IInstitutionAddressRepo institutionAddressRepo;
        public InstitutionEmailBussinessLogic(IInstitutionEmailRepo Repo, IInstitutionAddressRepo addressRepo)
        {
            InstitutionEmailRepository = Repo;
            institutionAddressRepo = addressRepo;
        }

        public int DeleteInstitutionEmail(int id)
        {
            return InstitutionEmailRepository.DeleteInstitutionEmail(id);
        }

        public InstitutionEmail GetByInstitutionEmailId(int id)
        {
            return InstitutionEmailRepository.GetByInstitutionEmailId(id);
        }

        public List<InstitutionEmail> GetInstitutionEmails()
        {
            return InstitutionEmailRepository.GetInstitutionEmails();
        }

        public int InsertInstitutionEmail(InstitutionEmail institutionEmail)
        {
            return InstitutionEmailRepository.InsertInstitutionEmail(institutionEmail);
        }

        public int UpdateInstitutionEmail(InstitutionEmail institutionEmail)
        {
            return InstitutionEmailRepository.UpdateInstitutionEmail(institutionEmail);
        }

        public List<InstitutionEmailList> GetInstitutionEmailList()
        {
            var institutionemail = InstitutionEmailRepository.GetInstitutionEmails();
            var institutionaddress = institutionAddressRepo.GetInstitutionAddress();

            var data = from i in institutionemail
                       join
                       inaddresss in institutionaddress on
                       i.InstitutionAddressId equals inaddresss.Id

                       select new InstitutionEmailList
                       {
                           Id = i.Id,
                           Address1 = inaddresss.Address1,
                           Email = i.Email,
                           IsPrimary = i.IsPrimary,
                           OrderId = i.OrderId

                       };
            return data.ToList();
        }

        public List<InstitutionEmail> GetInstitutionEmailsByAddressId(int addressId)
        {
            return InstitutionEmailRepository.GetInstitutionEmailsByAddressId(addressId);
        }
    }
}
