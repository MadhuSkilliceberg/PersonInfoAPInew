using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CompanyReviewBusinessLogic : ICompanyReviewBusinessLogic
    {
        private readonly ICompanyReviewRepository companyReviewRepository;

        public CompanyReviewBusinessLogic(ICompanyReviewRepository companyReviewRepository)
        {
            this.companyReviewRepository = companyReviewRepository;
        }

        public async Task<int> AddCompanyReview(CompanyReview companyReview)
        {
            return await companyReviewRepository.AddCompanyReview(companyReview);
        }

        public async Task<int> AddRangeCompanyReview(List<CompanyReview> companyReviews)
        {
            return await companyReviewRepository.AddRangeCompanyReview(companyReviews);
        }

        public async Task<int> DeleteCompanyReview(int id)
        {
            return await companyReviewRepository.DeleteCompanyReview(id);
        }

        public async Task<int> DeleteRangeCompanyReview(List<int> ids)
        {
            return await companyReviewRepository.DeleteRangeCompanyReview(ids);
        }

        public async Task<List<CompanyReviewModel>> GetByCompanyReviewComapanyId(int companyId)
        {
            return await companyReviewRepository.GetByCompanyReviewComapanyId(companyId);
        }

        public async Task<List<CompanyReview>> GetByCompanyReviewComapanyId1(int companyId)
        {
            return await companyReviewRepository.GetByCompanyReviewComapanyId1(companyId);
        }

        public async Task<CompanyReview> GetCompanyReviewById(int id)
        {
            return await companyReviewRepository.GetCompanyReviewById(id);
        }

        public async Task<List<CompanyReview>> GetcompanyReviews()
        {
            return await companyReviewRepository.GetcompanyReviews();
        }
        public async Task<int> UpdateCompanyReview(CompanyReview companyReview)
        {
            return await companyReviewRepository.UpdateCompanyReview(companyReview);
        }

        public async Task<int> UpdateRangeCompanyReview(List<CompanyReview> companyReviews)
        {
            return await companyReviewRepository.UpdateRangeCompanyReview(companyReviews);
        }
        public async Task<List<CompanyReviewsCommentModel>> GetByCompanyReviewComments(int reviewId)
        {
            return await companyReviewRepository.GetByCompanyReviewComments(reviewId);
        }

        public async Task<List<object>> GetCompanyReviewTreeHierarchical(int reviewId)
        {
            List<CompanyReviewsCommentModel> categories = await GetByCompanyReviewComments(reviewId);

            List<CompanyReviewsCommentModel> rootCategories = categories.Where(c => !c.ParentId.HasValue).ToList();
            List<object> result = new List<object>();

            foreach (CompanyReviewsCommentModel rootCategory in rootCategories)
            {
                result.Add(BuildCategoryTree(rootCategory, categories));
            }
            return result;
        }

        private async Task<object> BuildCategoryTree(CompanyReviewsCommentModel category, List<CompanyReviewsCommentModel> categories)
        {
            var children = categories.Where(c => c.ParentId == category.Id).ToList();
            if (children.Count == 0)
            {
                return new
                {

                    description = category.Description,
                    title = category.Heading,
                    id = category.Id,
                    children = new List<object>()
                };
            }
            else
            {
                var childNodes = new List<object>();
                foreach (var child in children)
                {
                    childNodes.Add(BuildCategoryTree(child, categories));
                }

                return new
                {
                    description = category.Description,
                    title = category.Heading,
                    id = category.Id,
                    children = childNodes
                };
            }
        }
    }
}

