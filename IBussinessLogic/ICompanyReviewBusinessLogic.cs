using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ICompanyReviewBusinessLogic
    {
        public List<CompanyReview> GetcompanyReviews();
        public int InsertCompanyReview(CompanyReview companyReview);

        public int UpdateCompanyReview(CompanyReview companyReview);

        public int DeleteCompanyReview(int id);

        public CompanyReview GetByCompanyReviewId(int id);

        public List<CompanyReviewModel> GetByCompanyReviewComapanyId(int id);
        public List<CompanyReview> GetByCompanyReviewComapanyId1(int id);
        public List<CompanyReviewsCommentModel> GetByCompanyReviewComments(int reviewId);

        public List<object> GetCompanyReviewTreeHierarchical(int reviewId);
    }
}
