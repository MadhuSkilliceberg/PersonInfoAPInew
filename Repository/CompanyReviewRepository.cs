using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.Models;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class CompanyReviewRepository : ICompanyReviewRepository
    {
        private readonly PersonsInfoV3NewContext context;

        public CompanyReviewRepository(PersonsInfoV3NewContext personsInfoV3NewContext)
        {
            context = personsInfoV3NewContext;
        }

        public async Task<List<CompanyReview>> GetcompanyReviews()
        {
            return await context.CompanyReviews.ToListAsync();
        }

        public async Task<int> AddCompanyReview(CompanyReview companyReview)
        {
            await context.CompanyReviews.AddAsync(companyReview);
            await context.SaveChangesAsync();
            return companyReview.Id;
        }

        public async Task<int> AddRangeCompanyReview(List<CompanyReview> companyReviews)
        {
            try
            {
                if (companyReviews != null)
                {
                    await context.CompanyReviews.AddRangeAsync(companyReviews);
                    await context.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> UpdateCompanyReview(CompanyReview companyReview)
        {
            context.CompanyReviews.Update(companyReview);
            await context.SaveChangesAsync();
            return companyReview.Id;
        }

        public async Task<int> UpdateRangeCompanyReview(List<CompanyReview> companyReviews)
        {
            try
            {
                if (companyReviews != null)
                {
                    context.CompanyReviews.UpdateRange(companyReviews);
                    await context.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> DeleteCompanyReview(int id)
        {
            context.CompanyReviews.Remove(await context.CompanyReviews.Where(a => a.Id == id).FirstOrDefaultAsync());
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> DeleteRangeCompanyReview(List<int> ids)
        {
            context.CompanyReviews.RemoveRange(await context.CompanyReviews.Where(a => ids.Contains(a.Id)).ToListAsync());
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<CompanyReview> GetCompanyReviewById(int id)
        {
            return await context.CompanyReviews.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<CompanyReviewModel>> GetByCompanyReviewComapanyId(int companyId)
        {

            var k = await context.CompanyReviews.Where(a => a.CompanyId == companyId).ToListAsync();

            var reviews = (from c in await context.CompanyReviews.ToListAsync()
                           join o in await context.Reviews.ToListAsync()

                           on c.ReviewId equals o.Id
                           select new CompanyReviewModel
                           {
                               CompanyId = c.CompanyId,
                               Id = o.Id,

                               Heading = o.Heading,
                               Description = o.Description,
                               Rating = o.Rating,
                               IsActive = o.IsActive,
                               IsPublic = o.IsPublic,
                               AccessLevel = o.AccessLevel,
                               CreatedOn = c.CreatedOn,
                               CreatedBy = c.CreatedBy,
                               UpdatedOn = c.UpdatedOn,
                               UpdatedBy = c.UpdatedBy,
                               TotalComments = 15

                           }).ToList();
            return reviews;
        }

        public async Task<List<CompanyReview>> GetByCompanyReviewComapanyId1(int companyId)
        {
            var k = await context.CompanyReviews.Where(a => a.CompanyId == companyId).ToListAsync();

            var partialResult = (from c in await context.CompanyReviews.ToListAsync()
                                 join o in await context.Reviews.ToListAsync()

                                 on c.ReviewId equals o.Id
                                 select new
                                 {
                                     c.CompanyId,
                                     o.Id,

                                     o.Heading,
                                     o.Description,
                                     o.Rating,
                                     o.IsActive,
                                     o.IsPublic,
                                     o.AccessLevel,
                                     o.CreatedOn,
                                     o.CreatedBy,
                                     o.UpdatedOn,
                                     o.UpdatedBy
                                 }).ToList();
            return k;
        }

        public async Task<List<CompanyReviewsCommentModel>> GetByCompanyReviewComments(int reviewId)
        {
            var partialResult = (from c in await context.ReviewsComments.Where(c => c.ReviewId == reviewId).ToListAsync()
                                 join o in await context.Comments.ToListAsync()
                                 on c.CommentId equals o.Id
                                 select new CompanyReviewsCommentModel
                                 {
                                     //   ReviewId= c.ReviewId,
                                     Id = o.Id,
                                     Heading = o.Heading,
                                     Description = o.Description,
                                     Rating = o.Rating,
                                     IsActive = o.IsActive,
                                     IsPublic = o.IsPublic,
                                     AccessLevel = o.AccessLevel,
                                     CreatedOn = o.CreatedOn,
                                     CreatedBy = o.CreatedBy,
                                     UpdatedOn = o.UpdatedOn,
                                     UpdatedBy = o.UpdatedBy
                                 }).ToList();
            return partialResult;
        }
    }
}
