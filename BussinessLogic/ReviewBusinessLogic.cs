using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class ReviewBusinessLogic: IReviewBusinessLogic
    {
        IReviewRepo ReviewRepo;

        public  ReviewBusinessLogic(IReviewRepo Repo)
        {
            ReviewRepo = Repo;
        }

        public int DeleteReview(int id)
        {
            return ReviewRepo.DeleteReview(id);
        }

        public Review GetByReviewId(int id)
        {
            return ReviewRepo.GetByReviewId(id);
        }

        public List<Review> GetReviews()
        {
            return ReviewRepo.GetReviews();
        }

        public int InsertReview(Review Review)
        {
            return ReviewRepo.InsertReview(Review);
        }

        public bool UpdateReview(Review Review)
        {
            return ReviewRepo.UpdateReview(Review);
        }

        
    }
}
