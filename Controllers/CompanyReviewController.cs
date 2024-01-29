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
using PersonsInfoV2Api.Models;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyReviewController : ControllerBase
    {
        ICompanyReviewBusinessLogic CompanyReviewBusinessLogic;

        public CompanyReviewController(ICompanyReviewBusinessLogic Repo)
        {
            CompanyReviewBusinessLogic = Repo;
        }
        [Route("DeleteCompanyReviews/{id}")]
        [HttpDelete]
        public int DeleteCompanyReview(int id)
        {
            return CompanyReviewBusinessLogic.DeleteCompanyReview(id);
        }


        [Route("GetCompanyReviewsById/{id}")]
        [HttpGet]
        public CompanyReview GetByCompanyReviewId(int id)
        {
            return CompanyReviewBusinessLogic.GetByCompanyReviewId(id);
        }

        [Route("GetByCompanyReviewComapanyId1/{id}")]
        [HttpGet]
        public List<CompanyReview> GetByCompanyReviewComapanyId1(int id)
        {
            return CompanyReviewBusinessLogic.GetByCompanyReviewComapanyId1(id);
        }

        [Route("GetByCompanyReviewComapanyId/{id}")]
        [HttpGet]
        public List<CompanyReviewModel> GetByCompanyReviewComapanyId(int id)
        {
            return CompanyReviewBusinessLogic.GetByCompanyReviewComapanyId(id);
        }




        [Route("GetCompanyReviews")]
        [HttpGet]
        public List<CompanyReview> GetcompanyReviews()
        {
            return CompanyReviewBusinessLogic.GetcompanyReviews();
        }


        [Route("AddCompanyReviews")]
        [HttpPost]
        public int InsertCompanyReview(CompanyReview CompanyReview)
        {
            return CompanyReviewBusinessLogic.InsertCompanyReview(CompanyReview);
        }


        [Route("UpdateCompanyReviews")]
        [HttpPut]
        public int UpdateCompanyReview(CompanyReview CompanyReview)
        {

            return CompanyReviewBusinessLogic.UpdateCompanyReview(CompanyReview);

        }

        [Route("GetByCompanyReviewComments")]
        [HttpPut]
        public List<CompanyReviewsCommentModel> GetByCompanyReviewComments(int reviewId)
        {

            return CompanyReviewBusinessLogic.GetByCompanyReviewComments(reviewId);

        }
        [Route("GetCompanyReviewTreeHierarchical/{id}")]
        [HttpGet]
        public List<object> GetCompanyReviewTreeHierarchical(int id)
        {

            return CompanyReviewBusinessLogic.GetCompanyReviewTreeHierarchical(id);

        }

       
    }
}
