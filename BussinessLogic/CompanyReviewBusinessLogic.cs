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
        ICompanyReviewRepo  companyReviewRepo;

        public CompanyReviewBusinessLogic(ICompanyReviewRepo companyReviewRepo)
        {
            this.companyReviewRepo = companyReviewRepo;
        }

        public int DeleteCompanyReview(int id)
        {
            return companyReviewRepo.DeleteCompanyReview(id);
        }

        public CompanyReview GetByCompanyReviewId(int id)
        {
            return companyReviewRepo.GetByCompanyReviewId(id);
        }
        public List<CompanyReview> GetByCompanyReviewComapanyId1(int id)
        {
            return companyReviewRepo.GetByCompanyReviewComapanyId1(id);
        }

        public List<CompanyReviewModel> GetByCompanyReviewComapanyId(int id)
        {
            return companyReviewRepo.GetByCompanyReviewComapanyId(id);
        }

        public List<CompanyReview> GetcompanyReviews()
        {
            return companyReviewRepo.GetcompanyReviews();
        }

        public int InsertCompanyReview(CompanyReview companyReview)
        {
            return companyReviewRepo.InsertCompanyReview(companyReview);
        }

        public int UpdateCompanyReview(CompanyReview companyReview)
        {
            return companyReviewRepo.UpdateCompanyReview(companyReview);
        }
        public List<CompanyReviewsCommentModel> GetByCompanyReviewComments(int reviewId)
        {
           
            return companyReviewRepo.GetByCompanyReviewComments(reviewId);
        }

        public List<object> GetCompanyReviewTreeHierarchical(int reviewId)
        {
            List<CompanyReviewsCommentModel> categories = GetByCompanyReviewComments(reviewId);

            List<CompanyReviewsCommentModel> rootCategories = categories.Where(c => !c.ParentId.HasValue).ToList();
            List<object> result = new List<object>();

            foreach (CompanyReviewsCommentModel rootCategory in rootCategories)
            {
                result.Add(BuildCategoryTree(rootCategory, categories));
            }
            return result;
        }

        private object BuildCategoryTree(CompanyReviewsCommentModel category, List<CompanyReviewsCommentModel> categories)
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

