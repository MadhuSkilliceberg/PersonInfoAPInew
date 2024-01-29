using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.Models;
using PersonsInfoV2Api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface ICompanyReviewRepo
    {
        public List<CompanyReview> GetcompanyReviews();
        public int InsertCompanyReview(CompanyReview companyReview);

        public int UpdateCompanyReview(CompanyReview companyReview);

        public int DeleteCompanyReview(int id);

        public CompanyReview GetByCompanyReviewId(int id);
        public bool AddCompanyReview(List<CompanyReview> companyReviews);
        public List<CompanyReviewModel> GetByCompanyReviewComapanyId(int id);
        public List<CompanyReview> GetByCompanyReviewComapanyId1(int id);
        public List<CompanyReviewsCommentModel> GetByCompanyReviewComments(int reviewId);
        

    }
}
