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
        private readonly ICompanyRepository companyRepository;
        private readonly ICompanyContactRepository companyContactRepository;
        private readonly ICompanyAddressRepository companyAddressRepo;
        private readonly ICompanyEmailRepository companyEmailRepo;
        private readonly ICompanyReviewRepository companyReviewRepo;
        private readonly IReviewRepo reviewRepo;

        public CompanyBussinessLogic(
            ICompanyRepository companyRepository,
            ICompanyContactRepository companyContactRepository,
            ICompanyAddressRepository companyAddressRepo,
            ICompanyEmailRepository companyEmailRepo,
            ICompanyReviewRepository companyReviewRepo,
            IReviewRepo reviewRepo
        )
        {
            this.companyRepository = companyRepository;
            this.companyContactRepository = companyContactRepository;
            this.companyAddressRepo = companyAddressRepo;
            this.companyEmailRepo = companyEmailRepo;
            this.companyReviewRepo = companyReviewRepo;
            this.reviewRepo = reviewRepo;
        }

        public async Task<int> AddCompany(Company company)
        {
            return await companyRepository.AddCompany(company);
        }

        public async Task<bool> AddCompanyDetail(CompanyDetail companyDetail)
        {
            int companyId = await AddCompany(companyDetail.company);
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
                    companyAddressInsertedIDs = await companyAddressRepo.AddRangeCompanyAddress(companyDetail.companyaddress);
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
                    companyEmailsResult = await companyEmailRepo.AddRangeCompanyEmail(companyDetail.companyEmails) > 0;
                }
                if (companyDetail.companyContacts != null)
                {
                    companyDetail.companyContacts.ForEach(a => a.CompanyAddressId = companyId);
                    companyContactsResult = await companyContactRepository.AddRangeCompanyContact(companyDetail.companyContacts) > 0;
                }
                if (companyDetail.companyReviews != null)
                {
                    // companyDetail.companyReviews.ForEach(a => a.CompanyId = companyId);
                    List<int> ids = reviewRepo.InsertReviews(companyDetail.companyReviews);

                    foreach (var id in ids)
                    {
                        var companyreview = new CompanyReview();
                        companyreview.CompanyId = companyId;
                        companyreview.ReviewId = id;
                       await companyReviewRepo.AddCompanyReview(companyreview);
                    }

                }
                return companyAddressResult && companyEmailsResult && companyContactsResult && companyReviewsResult;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> AddCompanyTables(CompanyModels companyModels)
        {
            int companyId = await AddCompany(companyModels.company);
            if (companyId > 0)
            {
                if (companyModels.companyAddress != null)
                {
                    companyModels.companyAddress.CompanyId = companyId;
                    await companyAddressRepo.AddCompanyAddress(companyModels.companyAddress);
                }
                if (companyModels.CompanyContact != null)
                {
                    companyModels.CompanyContact.ContactTypeId = companyId;
                    await companyContactRepository.AddCompanyContact(companyModels.CompanyContact);
                }
                if (companyModels.companyEmail != null)
                {
                    companyModels.companyEmail.ContactTypeId = companyId;
                    await companyEmailRepo.AddCompanyEmail(companyModels.companyEmail);
                }
                if (companyModels.companyReview != null)
                {
                    companyModels.companyReview.CompanyId = companyId;
                   await companyReviewRepo.AddCompanyReview(companyModels.companyReview);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<int> AddRangeCompany(List<Company> companies)
        {
            return await companyRepository.AddRangeCompany(companies);
        }

        public async Task<bool> DeleteCompany(int id)
        {
            return await companyRepository.DeleteCompany(id);
        }

        public async Task<bool> DeleteRangeCompany(List<int> ids)
        {
            return await companyRepository.DeleteRangeCompany(ids);
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await companyRepository.GetCompanies();
        }

        public async Task<Company> GetCompanyById(int id)
        {
            return await companyRepository.GetCompanyById(id);
        }

        public async Task<int> UpdateCompany(Company company)
        {
            return await companyRepository.UpdateCompany(company);
        }

        public async Task<int> UpdateRangeCompany(List<Company> companies)
        {
            return await companyRepository.UpdateRangeCompany(companies);
        }
    }
}
