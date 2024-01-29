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
    public class CompanyReviewRepo : ICompanyReviewRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();


        public bool AddCompanyReview(List<CompanyReview> companyReviews)
        {
            try
            {
                if (companyReviews != null)
                {
                    Context.CompanyReviews.AddRange(companyReviews);
                    Context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateCompanyReview(List<CompanyReview> companyReviews)
        {
            try
            {
                if (companyReviews != null)
                {
                    Context.CompanyReviews.UpdateRange(companyReviews);
                    Context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public int DeleteCompanyReview(int id)
        {
            var k = Context.CompanyReviews.Where(a => a.Id == id).FirstOrDefault();
            Context.CompanyReviews.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public CompanyReview GetByCompanyReviewId(int id)
        {
            var k = Context.CompanyReviews.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<CompanyReviewModel> GetByCompanyReviewComapanyId(int id)
        {
            //List<CompanyReviewModel> companyReviewModels=new List<CompanyReviewModel>();

            //var k = Context.CompanyReviews.Where(a => a.CompanyId == id).ToList();

            //var partialResult = (from c in Context.CompanyReviews
            //                     join o in Context.Reviews
            //                     on c.ReviewId equals o.Id
            //                     join cm in Context.ReviewsComments on o.Id equals cm.ReviewId into j1
            //                     from j2 in j1.DefaultIfEmpty()
            //                     group j2 by c.ReviewId into grouped
            //                     select new CompanyReviewModel
            //                     {
            //                      CompanyId= grouped.FirstOrDefault().Id,
            //                         Reviews = grouped.Select(x => x.Review).ToList(),
            //                     }).ToList();

            //return partialResult;
            var k = Context.CompanyReviews.Where(a => a.CompanyId == id).ToList();

            var reviews = (from c in Context.CompanyReviews
                                 join o in Context.Reviews

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
                                     TotalComments=15
                                     
                                 }).ToList();



            //var query = from p in reviews
            //            join c in Context.ReviewsComments on p.ReviewId equals c.ReviewId into j1
            //            from j2 in j1.DefaultIfEmpty()
            //            group j2 by p.ReviewId into grouped
            //            select new CompanyReviewModel
            //            {
            //                CompanyId = grouped.Select(t=>t.)
            //                Id = o.Id,

            //                ParentId = grouped.Key, 
            //                Count = grouped.Count(t => t.CommentId > 0)
            //            };






            return reviews;
        }

        //public List<CompanyReviewModel> GetByCompanyReviewComapanyId(int id)
        //{
        //    var k = Context.CompanyReviews.Where(a => a.CompanyId == id).ToList();

        //    //var partialResult = (from c in Context.CompanyReviews
        //    //                     join o in Context.Reviews
        //    //                     on c.ReviewId equals o.Id
        //    //                     //join cm in Context.ReviewsComments on o.Id equals cm.ReviewId   into j1
        //    //                     //from j2 in j1.DefaultIfEmpty()
        //    //                     //group j2 by c.ReviewId into grouped
        //    //                     select new
        //    //                     {
        //    //                         c.CompanyId,
        //    //                         o.Id,

        //    //                         o.Heading,
        //    //                         o.Description,
        //    //                         o.Rating,
        //    //                         o.IsActive,
        //    //                         o.IsPublic,
        //    //                         o.AccessLevel,
        //    //                         o.CreatedOn,
        //    //                         o.CreatedBy,
        //    //                         o.UpdatedOn,
        //    //                         o.UpdatedBy
        //    //                     }).ToList();

        //    //var partialResult = (from c in Context.CompanyReviews
        //    //                     join o in Context.Reviews on c.ReviewId equals o.Id
        //    //                     join cm in Context.ReviewsComments on o.Id equals cm.ReviewId into j1
        //    //                     from j2 in j1.DefaultIfEmpty()
        //    //                     let leftJoinResult = new { Comment = j2, Review = o, CompanyId = c.CompanyId }
        //    //                     group leftJoinResult by leftJoinResult.Review.Id into grouped
        //    //                     select new CompanyReviewModel
        //    //                     {
        //    //                         ReviewId = grouped.Key,
        //    //                         TotalComments = grouped.Count(t => t.Comment.Id > 0),
        //    //                         Heading = grouped.Select(x => x.Review.Heading).FirstOrDefault(),
        //    //                         Description = grouped.Select(x => x.Review.Description).FirstOrDefault(),
        //    //                         Rating = grouped.Select(x => x.Review.Rating).FirstOrDefault(),
        //    //                         IsActive = grouped.Select(x => x.Review.IsActive).FirstOrDefault(),
        //    //                         IsPublic = grouped.Select(x => x.Review.IsPublic).FirstOrDefault(),
        //    //                         AccessLevel = grouped.Select(x => x.Review.AccessLevel).FirstOrDefault(),
        //    //                         CreatedOn = grouped.Select(x => x.Review.CreatedOn).FirstOrDefault(),
        //    //                         CreatedBy = grouped.Select(x => x.Review.CreatedBy).FirstOrDefault(),
        //    //                         UpdatedOn = grouped.Select(x => x.Review.UpdatedOn).FirstOrDefault(),
        //    //                         UpdatedBy = grouped.Select(x => x.Review.UpdatedBy).FirstOrDefault(),
        //    //                         CompanyId = Context.CompanyReviews
        //    //                                        .Where(cr => cr.ReviewId == grouped.Key)
        //    //                                        .Select(cr => cr.CompanyId)
        //    //                                        .FirstOrDefault()
        //    //                     }).ToList();


        //    //var partialResult = (from c in Context.CompanyReviews
        //    //                     join o in Context.Reviews on c.ReviewId equals o.Id
        //    //                     join cm in Context.ReviewsComments on o.Id equals cm.ReviewId into j1
        //    //                     from j2 in j1.DefaultIfEmpty()
        //    //                     let leftJoinResult = new { Comment = j2, Review = o, CompanyId = c.CompanyId }
        //    //                     group leftJoinResult by leftJoinResult.Review.Id into grouped
        //    //                     select new CompanyReviewModel
        //    //                     {
        //    //                         CompanyId = grouped.AsEnumerable().Select(x => x.CompanyId).FirstOrDefault(),
        //    //                         ReviewId = grouped.Key,
        //    //                         Heading = grouped.Select(x => x.Review.Heading).FirstOrDefault(),
        //    //                         Description = grouped.Select(x => x.Review.Description).FirstOrDefault(),
        //    //                         Rating = grouped.Select(x => x.Review.Rating).FirstOrDefault(),
        //    //                         IsActive = grouped.Select(x => x.Review.IsActive).FirstOrDefault(),
        //    //                         IsPublic = grouped.Select(x => x.Review.IsPublic).FirstOrDefault(),
        //    //                         AccessLevel = grouped.Select(x => x.Review.AccessLevel).FirstOrDefault(),
        //    //                         CreatedOn = grouped.Select(x => x.Review.CreatedOn).FirstOrDefault(),
        //    //                         CreatedBy = grouped.Select(x => x.Review.CreatedBy).FirstOrDefault(),
        //    //                         UpdatedOn = grouped.Select(x => x.Review.UpdatedOn).FirstOrDefault(),
        //    //                         UpdatedBy = grouped.Select(x => x.Review.UpdatedBy).FirstOrDefault()
        //    //                     }).ToList();

        //    var partialResult = (from c in Context.CompanyReviews
        //                         join o in Context.Reviews on c.ReviewId equals o.Id
        //                         join cm in Context.ReviewsComments on o.Id equals cm.ReviewId into j1
        //                         from j2 in j1.DefaultIfEmpty()
        //                         let leftJoinResult = new { Comment = j2, Review = o, CompanyId = c.CompanyId }
        //                         group leftJoinResult by leftJoinResult.Review.Id into grouped
        //                         select new CompanyReviewModel
        //                         {
        //                             ReviewId = grouped.Key,
        //                             Reviews = grouped.Select(x => x.Review).ToList(),
        //                             CompanyId = grouped.Select(x => x.CompanyId).FirstOrDefault()
        //                         })
        //              .AsEnumerable()  // Switch to client-side processing
        //              .Select(grouped => new
        //              {
        //                  ReviewId = grouped.ReviewId,
        //                  Heading = grouped.Reviews.FirstOrDefault()?.Heading,
        //                  Description = grouped.Reviews.FirstOrDefault()?.Description,
        //                  Rating = grouped.Reviews.FirstOrDefault()?.Rating,
        //                  IsActive = grouped.Reviews.FirstOrDefault()?.IsActive,
        //                  IsPublic = grouped.Reviews.FirstOrDefault()?.IsPublic,
        //                  AccessLevel = grouped.Reviews.FirstOrDefault()?.AccessLevel,
        //                  CreatedOn = grouped.Reviews.FirstOrDefault()?.CreatedOn,
        //                  CreatedBy = grouped.Reviews.FirstOrDefault()?.CreatedBy,
        //                  UpdatedOn = grouped.Reviews.FirstOrDefault()?.UpdatedOn,
        //                  UpdatedBy = grouped.Reviews.FirstOrDefault()?.UpdatedBy,
        //                  CompanyId = grouped.CompanyId
        //              })
        //              .ToList();


        //    return partialResult;
        //}

        public List<CompanyReview> GetByCompanyReviewComapanyId1(int id)
        {
            var k = Context.CompanyReviews.Where(a => a.CompanyId == id).ToList();

            var partialResult = (from c in Context.CompanyReviews
                                 join o in Context.Reviews

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

        public List<CompanyReview> GetcompanyReviews()
        {
            return Context.CompanyReviews.ToList();
        }

        public int InsertCompanyReview(CompanyReview companyReview)
        {
            Context.CompanyReviews.Add(companyReview);
            Context.SaveChanges();
            return companyReview.Id;
        }

        public int UpdateCompanyReview(CompanyReview companyReview)
        {
            Context.CompanyReviews.Update(companyReview);
            Context.SaveChanges();
            return companyReview.Id;
        }

        public List<CompanyReviewsCommentModel> GetByCompanyReviewComments(int reviewId)
        {
            var partialResult = (from c in Context.ReviewsComments.Where(c=>c.ReviewId==reviewId)
                                 join o in Context.Comments 
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
