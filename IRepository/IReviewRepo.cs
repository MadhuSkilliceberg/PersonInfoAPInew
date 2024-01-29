using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IReviewRepo
    {
        public List<Review> GetReviews();
        public int InsertReview(Review Review);

        public bool UpdateReview(Review Review);

        public int DeleteReview(int id);

        public Review GetByReviewId(int id);

        public List<int> InsertReviews(List<Review> Reviews);
        
    }
}
