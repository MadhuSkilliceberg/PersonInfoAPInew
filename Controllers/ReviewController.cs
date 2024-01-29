using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        IReviewBusinessLogic ReviewBusinessLogic;

        public ReviewController(IReviewBusinessLogic Repo)
        {
            ReviewBusinessLogic =Repo;
        }
        [Route("DeleteReviews/{Id}")]
        [HttpDelete]
        public int DeleteReview(int id)
        {
            return ReviewBusinessLogic.DeleteReview(id);
        }


        [Route("GetReviewsById/{Id}")]
        [HttpGet]
        public Review GetByReviewId(int id)
        {
            return ReviewBusinessLogic.GetByReviewId(id);
        }


        [Route("GetReviews")]
        [HttpGet]
        public List<Review> GetReviews()
        {
            return ReviewBusinessLogic.GetReviews();
        }


        [Route("AddReviews")]
        [HttpPost]
        public int InsertReview(Review Review)
        {
            return ReviewBusinessLogic.InsertReview(Review);
        }


        [Route("UpdateReviews")]
        [HttpPut]
        public bool UpdateReview(Review Review)
        {
           
                return ReviewBusinessLogic.UpdateReview(Review);
           
        }


        [Route("GetReviewComments")]
        [HttpGet]
        public List<Review> GetReviewComments(int reviewId)
        {
            return ReviewBusinessLogic.GetReviews();
        }
    }
}
