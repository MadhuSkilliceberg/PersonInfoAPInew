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
    public class InstitutionEmailBussinessLogic : IInstitutionEmailBussinessLogic
    {
        private readonly IInstitutionEmailRepository _institutionEmailRepository;
        private readonly IInstitutionAddressRepository _institutionAddressRepository;
        public InstitutionEmailBussinessLogic(IInstitutionEmailRepository institutionEmailRepository, IInstitutionAddressRepository institutionAddressRepository)
        {
            _institutionAddressRepository = institutionAddressRepository;
            _institutionEmailRepository = institutionEmailRepository;
        }

        public async Task<int> DeleteInstitutionEmailByInstitutionEmailId(int institutionEmailId)

        {
            return await _institutionEmailRepository.DeleteInstitutionEmailByInstitutionEmailId(institutionEmailId);
        }

        public async Task<InstitutionEmail> GetInstitutionEmailIdByinstitutionEmailId(int institutionEmailId)

        {
            return await _institutionEmailRepository.GetInstitutionEmailIdByinstitutionEmailId(institutionEmailId);
        }

        public async Task<List<InstitutionEmail>> GetInstitutionEmails()

        {
            return await _institutionEmailRepository.GetInstitutionEmails();
        }

        public async Task<int> AddInstitutionEmail(InstitutionEmail institutionEmail)

        {
            return await _institutionEmailRepository.AddInstitutionEmail(institutionEmail);
        }

        public async Task<int> UpdateInstitutionEmail(InstitutionEmail institutionEmail)

        {
            return await _institutionEmailRepository.UpdateInstitutionEmail(institutionEmail);
        }

        public async Task<List<InstitutionEmailList>> GetInstitutionEmailList()
        {
            var institutionEmails = await _institutionEmailRepository.GetInstitutionEmails();
            var institutionaddress = await _institutionAddressRepository.GetInstitutionAddresses();

            var data = from i in institutionEmails
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

        public async Task<List<InstitutionEmail>> GetInstitutionEmailsByAddressId(int addressId)

        {
            return await _institutionEmailRepository.GetInstitutionEmailsByAddressId(addressId);


        }
        public async Task<bool> UpdateRangeInstitutionEmails(List<InstitutionEmail> institutionEmails)
        {
            return await _institutionEmailRepository.UpdateRangeInstitutionEmails(institutionEmails);
        }
        public async Task<bool> AddRangeInstitutionEmails(List<InstitutionEmail> institutionEmails)
        {
            return await _institutionEmailRepository.AddRangeInstitutionEmails(institutionEmails);
        }

        public async Task<bool> DeleteRangeInstitutionEmails(List<InstitutionEmail> institutionEmails)
        {
            return await _institutionEmailRepository.DeleteRangeInstitutionEmails(institutionEmails);
        }



    }
}
