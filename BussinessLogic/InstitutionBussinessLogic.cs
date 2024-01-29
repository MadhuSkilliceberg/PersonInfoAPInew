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
    public class InstitutionBussinessLogic: IInstitutionBussinessLogic
    {
        IInstitutionRepo InstitutionRepository;
        IQualificationtypeRepo qualificationtype;
        IMediumRepo mediumRepo;
        IInstitutionAddressRepo institutionAddRepo;
        IInstitutionContactRepo institutionContactRepo;
        IInstitutionEmailRepo institutionEmailRepo;
        IRepoInstitutionCourse repoInstitutionCourse;


        public InstitutionBussinessLogic(
            IInstitutionRepo Repo,
            IQualificationtypeRepo qualificationtypes,
            IMediumRepo mediumRepos,
            IInstitutionAddressRepo institutionAddressRepo,
            IInstitutionContactRepo institutionContact,
            IInstitutionEmailRepo  institutionEmail,
            IRepoInstitutionCourse repoInstitution

            )

        {
            InstitutionRepository = Repo;
            qualificationtype = qualificationtypes;
            mediumRepo = mediumRepos;
            institutionAddRepo = institutionAddressRepo;
            institutionContactRepo = institutionContact;
            institutionEmailRepo = institutionEmail;
            repoInstitutionCourse = repoInstitution;

        }

        public int DeleteInstitution(int id)
        {
            return InstitutionRepository.DeleteInstitution(id);
        }

        public Institution GetByInstitutionId(int id)
        {
            return InstitutionRepository.GetByInstitutionId(id);
        }

      

        public List<Institution> GetInstitutions()
        {
            return InstitutionRepository.GetInstitutions();
        }

        public int InsertInstitution(Institution institution)
        {
            return InstitutionRepository.InsertInstitution(institution);
        }

        public int UpdateInstitution(Institution institution)
        {
            return InstitutionRepository.UpdateInstitution(institution);
        }

        public List<Qualificationcs> GetQualificationcs()
        {
            //List<Qualificationcs> qualificationcs = new List<Qualificationcs>();
            var institutiondata = InstitutionRepository.GetInstitutions();
            var Qualificationdata = qualificationtype.GetUsers();
            var mediumdata = mediumRepo.GetUsers();


            var data = from i in institutiondata
                       join
                       s in Qualificationdata on
                       i.QulificationTypeId equals s.Id
                       join
                       m in mediumdata on
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

        public bool InstitutionModel(InstitutionModels institutionModels)
        {
            int institutionId = InsertInstitution(institutionModels.institutions);
            if(institutionId>0)
            {
                if (institutionModels.institutionaddress != null)
                {
                    institutionModels.institutionaddress.InstitutionId = institutionId;
                    institutionAddRepo.InsertInstitutionAddress(institutionModels.institutionaddress);

                }
                if (institutionModels.institutioncontacts != null)
                {
                    institutionModels.institutioncontacts.InstitutionAddressId = institutionId;
                    institutionContactRepo.InsertInstitutionContact(institutionModels.institutioncontacts);
                }
                if (institutionModels.institutionCourses != null)
                {
                    institutionModels.institutionCourses.InstitutionId = institutionId;
                    repoInstitutionCourse.InsertInstitutionCourse(institutionModels.institutionCourses);
                }
                if(institutionModels.institutionemail != null)
                {
                    institutionModels.institutionemail.InstitutionAddressId = institutionId;
                    institutionEmailRepo.InsertInstitutionEmail(institutionModels.institutionemail);
                }
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool InstitutionDetails(InstitutionDetails institutionDetails)

        {
            int institutionId = 0;
            if (institutionDetails.institutions.Id < 0)
            {
                institutionId = InsertInstitution(institutionDetails.institutions);
            }
            else
            {
                institutionId = UpdateInstitution(institutionDetails.institutions);
            }
            // int institutionaddress = institutionAddRepo.InsertInstitution(institutionDetails.institutionaddress);

            if (institutionId > 0)
            {
                if (institutionDetails.institutionaddress != null)
                {


                    institutionAddRepo.DeleteinstitutionAddressDetails(institutionDetails.institutionaddress.Where(n => n.IsDeleted == true).ToList());


                    foreach (var institutionadd in institutionDetails.institutionaddress)
                    {
                        
                        if (institutionadd.Id > 0)
                            institutionAddRepo.UpdateinstitutionAddress(institutionadd);
                        else
                            institutionAddRepo.InsertInstitutionAddress(institutionadd);



                        //Contacts start

                        institutionContactRepo.DeleteinstitutionContactsDetails(institutionadd.InstitutionContacts.Where(n => n.IsDeleted == true).ToList());


                        institutionContactRepo.UpdateinstitutionContactsDetails(institutionadd.InstitutionContacts.Where(n => n.Id >0).ToList());

                        foreach (var InstitutionCont in institutionadd.InstitutionContacts.Where(n => n.Id < 1))
                        {
                            InstitutionCont.InstitutionAddressId = institutionadd.Id;
                            institutionContactRepo.InsertInstitutionContact(InstitutionCont);
                        }

                        //Contacts End 

                        //Email start
                        // institutionEmailRepo.DeleteinstitutionEmailDetails(institutionadd.InstitutionEmails.Where(n => n.IsDeleted == true).ToList());


                        var data = institutionEmailRepo.GetInstitutionEmailsByAddressId(institutionadd.Id).Select(t=>t.Id);


                        institutionEmailRepo.DeleteinstitutionEmailDetails(institutionadd.InstitutionEmails.Where(n => !data.Contains(n.Id)).ToList());

                        institutionEmailRepo.UpdateinstitutionEmailDetails(institutionadd.InstitutionEmails.Where(n => n.Id > 0 ).ToList());

                        foreach (var InstitutionEmail in institutionadd.InstitutionEmails.Where(n => n.Id < 1))
                        {
                            InstitutionEmail.InstitutionAddressId = institutionadd.Id;
                            institutionEmailRepo.InsertInstitutionEmail(InstitutionEmail);
                        }
                            
                        //Email End

                    }



                    //institutionAddRepo.UpdateinstitutionAddressDetails(institutionDetails.institutionaddress.Where(n => n.Id > 0).ToList());

                    //foreach (var institutionadd in institutionDetails.institutionaddress.Where(n => n.Id < 1))
                    //{
                    //    institutionadd.InstitutionId = institutionId;
                    //}
                    //institutionAddRepo.AddinstitutionAddressDetails(institutionDetails.institutionaddress);




                }
                //if (institutionDetails.institutioncontacts != null)
                //{
                //    institutionDetails.institutioncontacts.ForEach(i => i.InstitutionAddressId = institutionId);
                //    institutionContactRepo.institutionContactsDetails(institutionDetails.institutioncontacts);
                //}
                //if (institutionDetails.institutionCourses != null)
                //{
                //    institutionDetails.institutionCourses.ForEach(i => i.InstitutionId = institutionId);
                //    repoInstitutionCourse.institutionCourseDetails(institutionDetails.institutionCourses);
                //}
                //if (institutionDetails.institutionemail != null)
                //{
                //    institutionDetails.institutionemail.ForEach(i => i.InstitutionAddressId = institutionId);
                //    institutionEmailRepo.institutionEmailDetails(institutionDetails.institutionemail);
                //}
                return true;
            }
            else
            {
                return false;
            }
        }

      
    }
}
