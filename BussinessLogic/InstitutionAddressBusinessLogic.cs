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
        IInstitutionAddressRepo InstitutionAddressRepository;
        IInstitutionBussinessLogic institutionBussiness;
        IStateBussinessLogic statebussinesslogic;
        ICountryBussinessLogic countrybussinessLogic;
        IMediumBussinessLogic mediumbussinessLogic;
        public InstitutionAddressBusinessLogic(IInstitutionAddressRepo repo, IInstitutionBussinessLogic institutionbussiness ,
                                               IStateBussinessLogic statebussiness, ICountryBussinessLogic countrybussiness, IMediumBussinessLogic mediumbussiness)
        {
            InstitutionAddressRepository = repo;
            institutionBussiness = institutionbussiness;
            statebussinesslogic = statebussiness;
            countrybussinessLogic = countrybussiness;
            mediumbussinessLogic = mediumbussiness;
        }
        public int DeleteInstitutionAddress(int id)
        {
            return InstitutionAddressRepository.DeleteInstitutionAddress(id);
        }

        public InstitutionAddress GetByInstitutionAddressId(int id)
        {
            return InstitutionAddressRepository.GetByInstitutionAddressId(id);
        }

        public List<InstitutionAddress> GetInstitutionAddresss()
        {
            return InstitutionAddressRepository.GetInstitutionAddress();
        }

        public int InsertInstitutionAddress(InstitutionAddress institutionAddress)
        {
            return InstitutionAddressRepository.InsertInstitutionAddress(institutionAddress);
        }

        public int UpdateInstitutionAddress(InstitutionAddress institutionAddress)
        {
            return InstitutionAddressRepository.UpdateinstitutionAddress(institutionAddress);
        }

        public List<InstitutionAddresslist> GetInstitutionAddresslist()
        {
            var InstitutionAddressRepositorydata = InstitutionAddressRepository.GetInstitutionAddress();
            var institutionBussinessdata = institutionBussiness.GetInstitutions();
            var statebussinesslogicdata = statebussinesslogic.GetUsers();
            var countrybussinessLogicdata = countrybussinessLogic.GetCountries();
            var mediumbussinessLogicdata = mediumbussinessLogic.GetUsers();

            var data = from i in InstitutionAddressRepositorydata
                       join
                       institution in institutionBussinessdata
                       on i.InstitutionId equals institution.Id
                       join
                       stat in statebussinesslogicdata
                       on i.StateId equals stat.Id
                       join
                       countryy in countrybussinessLogicdata
                       on i.CountryId equals countryy.Id
                       join
                       medium in mediumbussinessLogicdata
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
        public List<InstitutionAddress> GetInstitutionAddressByInstituteId(int instituteId)
        {
            return InstitutionAddressRepository.GetInstitutionAddressByInstituteId(instituteId);
        }

    }
}
