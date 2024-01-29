using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface IReviewBusinessLogic
    {
        public List<Review> GetReviews();
        public int InsertReview(Review Review);

        public bool UpdateReview(Review Review);

        public int DeleteReview(int id);

        public Review GetByReviewId(int id);

    }
}
