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
    public class InstitutionAddressBusinessLogic : IInstitutionAddressBusinessLogic
    {
      private readonly  IInstitutionAddressRepository _institutionAddressRepository;
      private readonly  IInstitutionBussinessLogic _institutionBussinessLogic;
      private readonly  IStateBussinessLogic _stateBussinessLogic;
      private readonly  ICountryBussinessLogic _countryBussinessLogic;
      private readonly  IMediumBussinessLogic _mediumBussinessLogic;
       public InstitutionAddressBusinessLogic(IInstitutionAddressRepository institutionAddressRepository, IInstitutionBussinessLogic institutionBussinessLogic ,
                                               IStateBussinessLogic stateBussinessLogic, ICountryBussinessLogic countryBussinessLogic, IMediumBussinessLogic mediumBussinessLogic)
        {
            _institutionAddressRepository = institutionAddressRepository;
            _institutionBussinessLogic = institutionBussinessLogic;
            _stateBussinessLogic = stateBussinessLogic;
            _countryBussinessLogic = countryBussinessLogic;
            _mediumBussinessLogic = mediumBussinessLogic;
        }
        public async Task<int> DeleteInstitutionAddressByInstitutionId(int institutionAddressId)
        {
            return await _institutionAddressRepository.DeleteInstitutionAddressByInstitutionId(institutionAddressId);
        }

        public async Task<InstitutionAddress> GetInstitutionAddressByInstitutionAdressId(int institutionAddressId)
        {
            return await _institutionAddressRepository.GetInstitutionAddressByInstitutionAdressId(institutionAddressId);
        }

        public async Task<List<InstitutionAddress>> GetInstitutionAddresses()
        {
            return  await _institutionAddressRepository.GetInstitutionAddresses();
        }

        public async  Task<int> AddInstitutionAddress(InstitutionAddress institutionAddress)
        {
            return await _institutionAddressRepository.AddInstitutionAddress(institutionAddress);
        }

        public async Task<int> UpdateInstitutionAddress(InstitutionAddress institutionAddress)
        {
            return await _institutionAddressRepository.UpdateInstitutionAddress(institutionAddress);
        }

        public async Task<List<InstitutionAddresslist>> GetInstitutionAddresslist()
        {
            var institutionAddressRepositoryData =await _institutionAddressRepository.GetInstitutionAddresses();
            var institutionBussinessData =await _institutionBussinessLogic.GetInstitutions();
            var statebussinesslogicData = _stateBussinessLogic.GetUsers();
            var countrybussinessLogicData = _countryBussinessLogic.GetCountries();
            var mediumbussinessLogicData = _mediumBussinessLogic.GetUsers();

            var data = from i in institutionAddressRepositoryData
                       join
                       institution in institutionBussinessData
                       on i.InstitutionId equals institution.Id
                       join
                       stat in statebussinesslogicData
                       on i.StateId equals stat.Id
                       join
                       countryy in countrybussinessLogicData
                       on i.CountryId equals countryy.Id
                       join
                       medium in mediumbussinessLogicData
                       on i.MeduimId equals medium.Id

                       select new InstitutionAddresslist
                       {
                           Id = i.Id,
                           InstitutionName = institution.InstitutionName,
                           FlotNo = i.FlotNo,
                           Address1 = i.Address1,
                           Address2 = i.Address2,
                           City = i.City,
                           StateName = stat.Name,
                           CountryName = countryy.Name,
                           Medium1 = medium.Name

                       };
            return data.ToList();



        }
        public async Task<List<InstitutionAddress>> GetInstitutionAddressByInstituteId(int instituteId)
        {
            return await _institutionAddressRepository.GetInstitutionAddressByInstituteId(instituteId);
        }



        public async Task<bool> AddRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses)
        {
            return await _institutionAddressRepository.AddRangeInstitutionAddresses(institutionAddresses);
        }


        public async Task<bool> UpdateRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses)
        {
            return await _institutionAddressRepository.UpdateRangeInstitutionAddresses(institutionAddresses);
        }

        public async Task<bool> DeleteRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses)
        {
            return await _institutionAddressRepository.UpdateRangeInstitutionAddresses(institutionAddresses);
        }


    }
}
