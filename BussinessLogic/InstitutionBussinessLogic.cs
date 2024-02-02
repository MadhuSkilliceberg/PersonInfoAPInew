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
    public class InstitutionBussinessLogic : IInstitutionBussinessLogic
    {
        private readonly IInstitutionRepository _institutionRepository;
        private readonly IQualificationtypeRepo _qualificationtype;
        private readonly IMediumRepo _mediumRepo;
        private readonly IInstitutionAddressRepository _institutionAddressRepository;
        private readonly IInstitutionContactRepository _institutionContactRepository;
        private readonly IInstitutionEmailRepository _institutionEmailRepository;
        private readonly IInstitutionCourseRepository _institutionCourseRepository;


        public InstitutionBussinessLogic(
            IInstitutionRepository institutionRepository,
            IQualificationtypeRepo qualificationtypes,
            IMediumRepo mediumRepos,
            IInstitutionAddressRepository institutionAddressRepository,
            IInstitutionContactRepository institutionContactRepository,
            IInstitutionEmailRepository institutionEmailRepository,
            IInstitutionCourseRepository institutionCourseRepository

            )

        {
            _institutionRepository = institutionRepository;
            _qualificationtype = qualificationtypes;
            _mediumRepo = mediumRepos;
            _institutionAddressRepository = institutionAddressRepository;
            _institutionEmailRepository = institutionEmailRepository;
            _institutionCourseRepository = institutionCourseRepository;
            _institutionContactRepository = institutionContactRepository;

        }

        public async Task<int> DeleteInstitutionByInstitutionId(int institutionId)

        {
            return await _institutionRepository.DeleteInstitutionByInstitutionId(institutionId);
        }

        public Task<Institution> GetInstitutionByInstitutionId(int institutionId)

        {
            return _institutionRepository.GetInstitutionByInstitutionId(institutionId);
        }



        public async Task<List<Institution>> GetInstitutions()
        {
            return await _institutionRepository.GetInstitutions();
        }

        public async Task<int> AddInstitution(Institution institution)

        {
            return await _institutionRepository.AddInstitution(institution);
        }

        public Task<int> UpdateInstitution(Institution institution)

        {
            return _institutionRepository.UpdateInstitution(institution);
        }

        public async Task<List<Qualificationcs>> GetQualificationcs()
        {
            //List<Qualificationcs> qualificationcs = new List<Qualificationcs>();
            var institutionData = await _institutionRepository.GetInstitutions();
            var qualificationData = _qualificationtype.GetUsers();
            var mediumData = _mediumRepo.GetUsers();


            var data = from i in institutionData
                       join
                       s in qualificationData on
                       i.QulificationTypeId equals s.Id
                       join
                       m in mediumData on
                       i.MediumId equals m.Id
                       select new Qualificationcs
                       {
                           Id = i.Id,
                           InstitutionName = i.InstitutionName,
                           QulificationName = s.Name,
                           Medium1 = m.Name

                       };
            return data.ToList();
        }

        public async Task<bool> InstitutionModel(InstitutionModels institutionModels)
        {
            int institutionId = await AddInstitution(institutionModels.institutions);
            if (institutionId > 0)
            {
                if (institutionModels.institutionaddress != null)
                {
                    institutionModels.institutionaddress.InstitutionId = institutionId;
                    await _institutionAddressRepository.AddInstitutionAddress(institutionModels.institutionaddress);

                }
                if (institutionModels.institutioncontacts != null)
                {
                    institutionModels.institutioncontacts.InstitutionAddressId = institutionId;
                    await _institutionContactRepository.AddInstitutionContact(institutionModels.institutioncontacts);
                }
                if (institutionModels.institutionCourses != null)
                {
                    institutionModels.institutionCourses.InstitutionId = institutionId;
                    await _institutionCourseRepository.AddInstitutionCourse(institutionModels.institutionCourses);
                }
                if (institutionModels.institutionemail != null)
                {
                    institutionModels.institutionemail.InstitutionAddressId = institutionId;
                    await _institutionEmailRepository.AddInstitutionEmail(institutionModels.institutionemail);
                }
                return true;
            }
            else
            {
                return false;
            }
        }



        public async Task<bool> InstitutionDetails(InstitutionDetails institutionDetails)

        {
            int institutionId = 0;
            if (institutionDetails.institutions.Id < 0)
            {
                institutionId = await AddInstitution(institutionDetails.institutions);
            }
            else
            {
                institutionId = await UpdateInstitution(institutionDetails.institutions);
            }
            bool institutionaddress = await _institutionAddressRepository.AddRangeInstitutionAddresses(institutionDetails.institutionaddress);

            if (institutionId > 0)
            {
                if (institutionDetails.institutionaddress != null)
                {


                    await _institutionAddressRepository.DeleteRangeInstitutionAddresses(institutionDetails.institutionaddress.Where(n => n.IsDeleted == true).ToList());


                    foreach (var institutionadd in institutionDetails.institutionaddress)
                    {

                        if (institutionadd.Id > 0)
                            await _institutionAddressRepository.UpdateInstitutionAddress(institutionadd);
                        else
                            await _institutionAddressRepository.AddInstitutionAddress(institutionadd);



                        //Contacts start

                        await _institutionContactRepository.DeleteRangeInstitutionContacts(institutionadd.InstitutionContacts.Where(n => n.IsDeleted == true).ToList());


                        await _institutionContactRepository.UpdateRangeInstitutionContacts(institutionadd.InstitutionContacts.Where(n => n.Id > 0).ToList());

                        foreach (var InstitutionCont in institutionadd.InstitutionContacts.Where(n => n.Id < 1))
                        {
                            InstitutionCont.InstitutionAddressId = institutionadd.Id;
                            await _institutionContactRepository.AddInstitutionContact(InstitutionCont);
                        }

                        //Contacts End 

                        //Email start
                        // institutionEmailRepo.DeleteinstitutionEmailDetails(institutionadd.InstitutionEmails.Where(n => n.IsDeleted == true).ToList());


                        var data = await _institutionEmailRepository.GetInstitutionEmailsByAddressId(institutionadd.Id).ConfigureAwait(false);//Select(t => t.Id);
                        var institutionEmailIds = data.Select(t => t.Id);

                        await _institutionEmailRepository.DeleteRangeInstitutionEmails(institutionadd.InstitutionEmails.Where(n => institutionEmailIds.Contains(n.Id)).ToList());

                        await _institutionEmailRepository.UpdateRangeInstitutionEmails(institutionadd.InstitutionEmails.Where(n => n.Id > 0).ToList());

                        foreach (var InstitutionEmail in institutionadd.InstitutionEmails.Where(n => n.Id < 1))
                        {
                            InstitutionEmail.InstitutionAddressId = institutionadd.Id;
                            await _institutionEmailRepository.AddInstitutionEmail(InstitutionEmail);
                        }

                        //    //Email End

                    }



                    await _institutionAddressRepository.UpdateRangeInstitutionAddresses(institutionDetails.institutionaddress.Where(n => n.Id > 0).ToList());

                    foreach (var institutionAddress in institutionDetails.institutionaddress.Where(n => n.Id < 1))
                    {
                        institutionAddress.InstitutionId = institutionId;
                    }
                    await _institutionAddressRepository.AddRangeInstitutionAddresses(institutionDetails.institutionaddress);




                }
                if (institutionDetails.institutioncontacts != null)
                {
                    institutionDetails.institutionCourses.ForEach(i => i.InstitutionId = institutionId);
                    await _institutionContactRepository.AddRangeInstitutionContacts(institutionDetails.institutioncontacts);
                }
                if (institutionDetails.institutionCourses != null)
                {
                    institutionDetails.institutionCourses.ForEach(i => i.InstitutionId = institutionId);
                  await  _institutionCourseRepository.AddRangeInstitutionCourseDetails(institutionDetails.institutionCourses);
                }
                if (institutionDetails.institutionemail != null)
                {
                    institutionDetails.institutionemail.ForEach(i => i.InstitutionAddressId = institutionId);
               await     _institutionEmailRepository.AddRangeInstitutionEmails(institutionDetails.institutionemail);
                }
                return true;
                }
                else
                {
                    return false;
                }
            }


        }
    }

