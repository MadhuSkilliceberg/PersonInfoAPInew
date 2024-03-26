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

        public async Task<List<Comment>> GetCompanyReviewCommentByParentId(int commentId)
        {
            return await companyReviewRepository.GetCompanyReviewCommentByParentId(commentId);
        }













        public async Task<List<object>> GetCompanyReviewTreeHierarchical(int reviewId)
        {
            List<CompanyReviewsCommentModel> companyReviewsComments  = await GetByCompanyReviewComments(reviewId);

            List<CompanyReviewsCommentModel> rootCategories = companyReviewsComments.Where(c => !c.ParentId.HasValue).ToList();
            List<object> result = new List<object>();

            foreach (CompanyReviewsCommentModel rootCategory in rootCategories)
            {
                result.Add(BuildCategoryTree(rootCategory, companyReviewsComments));
            }
            return result;
        }

        private async Task<object> BuildCategoryTree(CompanyReviewsCommentModel rootCategory, List<CompanyReviewsCommentModel> categories)
        {
            var children = categories.Where(c => c.ParentId == rootCategory.Id).ToList();
            if (children.Count == 0)
            {
                return new
                {

                    description = rootCategory.Description,
                    title = rootCategory.Heading,
                    id = rootCategory.Id,
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
                    description = rootCategory.Description,
                    title = rootCategory.Heading,
                    id = rootCategory.Id,
                    children = childNodes
                };
            }
        }



        public List<object> TreeHierarchical1(List<int> parentIds)
        {

            Func<int, List<Comment>> categoryLoader = parentId =>
            {
                // Fetch child categories for a given parent ID
                return companyReviewRepository.GetComments().Where(c => c.ParentId == parentId).ToList();
            };


            
           
            List<Comment> rootCategories = companyReviewRepository.GetComments().Where(c => parentIds.Contains(c.Id)).ToList();
            List<object> result = new List<object>();

            foreach (Comment rootCategory in rootCategories)
            {
                result.Add(BuildCategoryTree1(rootCategory, categoryLoader));
            }
            return result;
        }
        private object BuildCategoryTree1(Comment category, Func<int, List<Comment>> categoryLoader)
        {
            var children = categoryLoader(category.Id);

            if (children == null || children.Count == 0)
            {
                return new
                {
                    Id = category.Id,
                    Heading = category.Heading,
                    Description = category.Description,
                    title = category.Id,
                    children = new List<object>()
                };
            }
            else
            {
                var childNodes = new List<object>();
                foreach (var child in children)
                {
                    childNodes.Add(BuildCategoryTree1(child, categoryLoader));
                }

                return new
                {
                    Id = category.Id,
                    Heading = category.Heading,
                    Description = category.Description,
                    children = childNodes
                };
            }
        }

    }
}

