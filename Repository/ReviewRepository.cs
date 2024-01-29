using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.BussinessLogic;

namespace PersonsInfoV2Api.Repository
{
    public class ReviewRepository : IReviewRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteReview(int id)
        {
            var a = person.Reviews.Where(c => c.Id == id).FirstOrDefault();
            person.Reviews.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Review GetByReviewId(int id)
        {
            return person.Reviews.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Review> GetReviews()
        {
            return person.Reviews.ToList();
        }

        public int InsertReview(Review Review)
        {
            person.Reviews.Add(Review);
            person.SaveChanges();
            return Review.Id;

        }


        public List<int> InsertReviews(List<Review> reviews)
        {
            try
            {
                person.Reviews.AddRange(reviews);
                person.SaveChanges();
                // var insertedKeys = person.Reviews.Select(x => x.Id);
                var insertedKeys = reviews.Select(x => x.Id);
                return insertedKeys.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public bool UpdateReview(Review Review)
        {
            person.Reviews.Update(Review);
            person.SaveChanges();
            return true;
        }

      
    }
}
