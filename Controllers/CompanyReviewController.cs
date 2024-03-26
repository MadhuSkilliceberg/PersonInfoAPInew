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
        private readonly ICompanyReviewBusinessLogic companyReviewBusinessLogic;

        public CompanyReviewController(ICompanyReviewBusinessLogic  companyReviewBusinessLogic)
        {
            this.companyReviewBusinessLogic = companyReviewBusinessLogic;
        }

        [Route("DeleteCompanyReview/{id}")]
        [HttpDelete]
        public async Task<int> DeleteCompanyReview(int id)
        {
            return await companyReviewBusinessLogic.DeleteCompanyReview(id);
        }

        [Route("DeleteRangeCompanyReview")]
        [HttpDelete]
        public async Task<int> DeleteRangeCompanyReview(List<int> ids)
        {
            return await companyReviewBusinessLogic.DeleteRangeCompanyReview(ids);
        }


        [Route("GetCompanyReviewById/{id}")]
        [HttpGet]
        public async Task<CompanyReview> GetCompanyReviewById(int id)
        {
            return await companyReviewBusinessLogic.GetCompanyReviewById(id);
        }

        [Route("GetByCompanyReviewComapanyId1/{id}")]
        [HttpGet]
        public async Task<List<CompanyReview>> GetByCompanyReviewComapanyId1(int id)
        {
            return await companyReviewBusinessLogic.GetByCompanyReviewComapanyId1(id);
        }

        [Route("GetByCompanyReviewComapanyId/{id}")]
        [HttpGet]
        public async Task<List<CompanyReviewModel>> GetByCompanyReviewComapanyId(int id)
        {
            return await companyReviewBusinessLogic.GetByCompanyReviewComapanyId(id);
        }

        [Route("GetCompanyReviews")]
        [HttpGet]
        public async Task<List<CompanyReview>> GetcompanyReviews()
        {
            return await companyReviewBusinessLogic.GetcompanyReviews();
        }


        [Route("AddCompanyReview")]
        [HttpPost]
        public async Task<int> AddCompanyReview(CompanyReview CompanyReview)
        {
            return await companyReviewBusinessLogic.AddCompanyReview(CompanyReview);
        }

        [Route("AddRangeCompanyReview")]
        [HttpPost]
        public async Task<int> AddRangeCompanyReview(List<CompanyReview> CompanyReviews)
        {
            return await companyReviewBusinessLogic.AddRangeCompanyReview(CompanyReviews);
        }


        [Route("UpdateCompanyReview")]
        [HttpPut]
        public async Task<int> UpdateCompanyReview(CompanyReview CompanyReview)
        {
            return await companyReviewBusinessLogic.UpdateCompanyReview(CompanyReview);
        }

        [Route("UpdateRangeCompanyReview")]
        [HttpPut]
        public async Task<int> UpdateRangeCompanyReview(List<CompanyReview> CompanyReviews)
        {
            return await companyReviewBusinessLogic.UpdateRangeCompanyReview(CompanyReviews);
        }

        [Route("GetByCompanyReviewComments/{reviewId}")]
        [HttpGet]
        public async Task<List<CompanyReviewsCommentModel>> GetByCompanyReviewComments(int reviewId)
        {
            return await companyReviewBusinessLogic.GetByCompanyReviewComments(reviewId);
        }

        [Route("GetCompanyReviewTreeHierarchical/{id}")]
        [HttpGet]
        public async Task<List<object>> GetCompanyReviewTreeHierarchical(int id)
        {
            return await companyReviewBusinessLogic.GetCompanyReviewTreeHierarchical(id);

        }

        [Route("GetCommentsTreeHierarchical")]
        [HttpPost]
        public List<object> GetCommentsTreeHierarchical(List<int> id)
        {
            
            return companyReviewBusinessLogic.TreeHierarchical1(id);

        }


    }
}
