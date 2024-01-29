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
    public class CompanyBussinessLogic : ICompanyBussinessLogic
    {
        private ICompanyRepo companyRepo;
        ICompanyContactRepo companyContactRepo;
        ICompanyAddressRepo companyAddressRepo;
        ICompanyEmailRepo companyEmailRepo;
        ICompanyReviewRepo companyReviewRepo;
        IReviewRepo ReviewRepo;


        public CompanyBussinessLogic(
            ICompanyRepo Repo,
            ICompanyContactRepo companyContactRepo,
            ICompanyAddressRepo companyAddressRepo,
            ICompanyEmailRepo companyEmailRepo,
            ICompanyReviewRepo companyReviewRepo,
            IReviewRepo reviewRepo
        )
        {
            companyRepo = Repo;
            this.companyContactRepo = companyContactRepo;
            this.companyAddressRepo = companyAddressRepo;
            this.companyEmailRepo = companyEmailRepo;
            this.companyReviewRepo = companyReviewRepo;
            this.ReviewRepo = reviewRepo;

        }



        public int DeleteCompany(int id)
        {
            return companyRepo.DeleteCompany(id);
        }


        public Company GetByCompanyId(int id)
        {
            return companyRepo.GetByCompanyId(id);

        }


        public List<Company> GetCompanys()
        {
            return companyRepo.GetCompany();
        }

        public int InsertCompany(Company company)
        {
            return companyRepo.InsertCompany(company);
        }

        public int UpdateCompany(Company company)
        {
            return companyRepo.UpdateCompany(company);
        }


        public bool AddCompanyDetail(CompanyDetail companyDetail)
        {
            int companyId = InsertCompany(companyDetail.company);
            bool companyAddressResult = true;
            bool companyEmailsResult = true;
            bool companyContactsResult = true;
            bool companyReviewsResult = true;
            List<int> companyAddressInsertedIDs = new List<int>();
            if (companyId > 0)
            {

                if (companyDetail.companyaddress != null)
                {
                    companyDetail.companyaddress.ForEach(a => a.CompanyId = companyId);
                    companyAddressInsertedIDs = companyAddressRepo.AddCompanyAddress(companyDetail.companyaddress);
                }


                if (companyDetail.companyEmails != null)
                {
                    if (companyAddressInsertedIDs != null && companyAddressInsertedIDs.Count > 0)
                    {

                        foreach (var id in companyAddressInsertedIDs)
                        {
                            companyDetail.companyEmails.ForEach(a => a.CompanyAddressId = id);
                        }



                        companyDetail.companyEmails.ForEach(a => a.CompanyAddressId = companyId);
                    }

                    companyDetail.companyEmails.ForEach(a => a.CompanyAddressId = companyId);
                    companyEmailsResult = companyEmailRepo.AddCompanyEmail(companyDetail.companyEmails);
                }
                if (companyDetail.companyContacts != null)
                {
                    companyDetail.companyContacts.ForEach(a => a.CompanyAddressId = companyId);
                    companyContactsResult = companyContactRepo.AddCompanyContact(companyDetail.companyContacts);
                }
                if (companyDetail.companyReviews != null)
                {
                    // companyDetail.companyReviews.ForEach(a => a.CompanyId = companyId);
                    List<int> ids = ReviewRepo.InsertReviews(companyDetail.companyReviews);

                    foreach (var id in ids)
                    {
                        var companyreview = new CompanyReview();
                        companyreview.CompanyId = companyId;
                        companyreview.ReviewId = id;
                        companyReviewRepo.InsertCompanyReview(companyreview);
                    }


                }
                return companyAddressResult && companyEmailsResult && companyContactsResult && companyReviewsResult;
            }
            else
            {
                return false;
            }


        }

        //        if (institutionDetails.institutionaddress != null)
        //        {


        //            institutionAddRepo.DeleteinstitutionAddressDetails(institutionDetails.institutionaddress.Where(n => n.IsDeleted == true).ToList());

        //            foreach (var institutionadd in institutionDetails.institutionaddress)
        //            {
        //                var institutionAddressList = institutionAddRepo.GetInstitutionAddressByInstituteId(institutionadd.Id).Select(t => t.Id);

        //                //institutionAddRepo.UpdateinstitutionAddressDetails(institutionDetails.institutionaddress.Where(n => n.Id > 0).ToList());

        //                if (institutionadd.Id > 0)
        //                    institutionAddRepo.UpdateinstitutionAddress(institutionadd);
        //                else
        //                    institutionAddRepo.InsertInstitutionAddress(institutionadd);



        //                //Contacts start

        //                var data1 = institutionContactRepo.GetInstitutionContactsByAddressId(institutionadd.Id).Select(t => t.Id);

        //                institutionContactRepo.DeleteinstitutionContactsDetails(institutionadd.InstitutionContacts.Where(n => n.IsDeleted == true).ToList());


        //                institutionContactRepo.UpdateinstitutionContactsDetails(institutionadd.InstitutionContacts.Where(n => n.Id > 0).ToList());

        //                foreach (var InstitutionCont in institutionadd.InstitutionContacts.Where(n => n.Id < 1))
        //                {
        //                    InstitutionCont.InstitutionAddressId = institutionadd.Id;
        //                    institutionContactRepo.InsertInstitutionContact(InstitutionCont);
        //                }

        //                //Contacts End 



        //                //Email start
        //                // institutionEmailRepo.DeleteinstitutionEmailDetails(institutionadd.InstitutionEmails.Where(n => n.IsDeleted == true).ToList());

        //                var data = institutionEmailRepo.GetInstitutionEmailsByAddressId(institutionadd.Id).Select(t => t.Id);

        //                institutionEmailRepo.DeleteinstitutionEmailDetails(institutionadd.InstitutionEmails.Where(n => !data.Contains(n.Id)).ToList());

        //                institutionEmailRepo.UpdateinstitutionEmailDetails(institutionadd.InstitutionEmails.Where(n => n.Id > 0).ToList());

        //                foreach (var InstitutionEmail in institutionadd.InstitutionEmails.Where(n => n.Id < 1))
        //                {
        //                    InstitutionEmail.InstitutionAddressId = institutionadd.Id;
        //                    institutionEmailRepo.InsertInstitutionEmail(InstitutionEmail);
        //                }

        //                //Email End

        //            }



        //            //institutionAddRepo.UpdateinstitutionAddressDetails(institutionDetails.institutionaddress.Where(n => n.Id > 0).ToList());

        //            //foreach (var institutionadd in institutionDetails.institutionaddress.Where(n => n.Id < 1))
        //            //{
        //            //    institutionadd.InstitutionId = institutionId;
        //            //}
        //            //institutionAddRepo.AddinstitutionAddressDetails(institutionDetails.institutionaddress);




        //        }
        //        //if (institutionDetails.institutioncontacts != null)
        //        //{
        //        //    institutionDetails.institutioncontacts.ForEach(i => i.InstitutionAddressId = institutionId);
        //        //    institutionContactRepo.institutionContactsDetails(institutionDetails.institutioncontacts);
        //        //}
        //        //if (institutionDetails.institutionCourses != null)
        //        //{
        //        //    institutionDetails.institutionCourses.ForEach(i => i.InstitutionId = institutionId);
        //        //    repoInstitutionCourse.institutionCourseDetails(institutionDetails.institutionCourses);
        //        //}
        //        //if (institutionDetails.institutionemail != null)
        //        //{
        //        //    institutionDetails.institutionemail.ForEach(i => i.InstitutionAddressId = institutionId);
        //        //    institutionEmailRepo.institutionEmailDetails(institutionDetails.institutionemail);
        //        //}
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }








        //public bool GetCompanyDetail(CompanyDetail companyDetail)
        //{
        //    int companyId = InsertCompany(companyDetail.company);
        //    bool companyAddressResult = false;
        //    bool companyEmailsResult = false;
        //    bool companyContactsResult = false;
        //    bool companyReviewsResult = false;
        //    if (companyId > 0)
        //    {



        //        if (companyDetail.companyaddress != null)
        //        {

        //            companyDetail.companyaddress = companyDetail.companyaddress.Where(a => a.CompanyId == companyId).ToList();
        //        }
        //        if (companyDetail.companyEmails != null)
        //        {
        //            companyDetail.companyEmails.ForEach(a => a.CompanyAddressId = companyId); 
        //        }
        //        if (companyDetail.companyContacts != null)
        //        {
        //            companyDetail.companyContacts.ForEach(a => a.CompanyAddressId = companyId);
        //        }
        //        if (companyDetail.companyReviews != null)
        //        {
        //            companyDetail.companyReviews.ForEach(a => a.CompanyReviews = companyId);
        //        }
        //        return companyAddressResult && companyEmailsResult && companyContactsResult && companyReviewsResult;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}



        public bool AddCompanyTables(CompanyModels companyModels)
        {
            int companyId = InsertCompany(companyModels.company);
            if (companyId > 0)
            {
                if (companyModels.companyAddress != null)
                {
                    companyModels.companyAddress.CompanyId = companyId;
                    companyAddressRepo.InsertCompanyAddress(companyModels.companyAddress);
                }
                if (companyModels.CompanyContact != null)
                {
                    companyModels.CompanyContact.ContactTypeId = companyId;
                    companyContactRepo.InsertCompanyContact(companyModels.CompanyContact);
                }
                if (companyModels.companyEmail != null)
                {
                    companyModels.companyEmail.ContactTypeId = companyId;
                    companyEmailRepo.InsertCompanyEmail(companyModels.companyEmail);
                }
                if (companyModels.companyReview != null)
                {
                    companyModels.companyReview.CompanyId = companyId;
                    companyReviewRepo.InsertCompanyReview(companyModels.companyReview);
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
