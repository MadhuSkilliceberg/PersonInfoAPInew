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
        public Task<List<CompanyReview>> GetcompanyReviews();
        public Task<int> AddCompanyReview(CompanyReview companyReview);
        public Task<int> AddRangeCompanyReview(List<CompanyReview> companyReviews);
        public Task<int> UpdateCompanyReview(CompanyReview companyReview);
        public Task<int> UpdateRangeCompanyReview(List<CompanyReview> companyReviews);
        public Task<int> DeleteCompanyReview(int id);
        public Task<int> DeleteRangeCompanyReview(List<int> ids);
        public Task<CompanyReview> GetCompanyReviewById(int id);
        public Task<List<CompanyReviewModel>> GetByCompanyReviewComapanyId(int companyId);
        public Task<List<CompanyReview>> GetByCompanyReviewComapanyId1(int companyId);
        public Task<List<object>> GetCompanyReviewTreeHierarchical(int reviewId);
        public Task<List<CompanyReviewsCommentModel>> GetByCompanyReviewComments(int reviewId);

        public List<object> TreeHierarchical1(List<int> parentIds);
    }
}
