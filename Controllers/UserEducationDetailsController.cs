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
using PersonsInfoV2Api.BussinessLogic;

namespace PersonsInfoV2Api.Controllers
{
    [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class UserEducationDetailsController : ControllerBase
    {
        IUserEducationDetailsBussinessLogic userEducationDetailsBussinessLogic;

        public UserEducationDetailsController(IUserEducationDetailsBussinessLogic Logic)
        {
            userEducationDetailsBussinessLogic = Logic;
        }


        [Route("GetUserEducationDetails")]
        [HttpGet]
        public async Task<List<UserEducationDetail>> GetUserEducationDetails()
        {
            return await userEducationDetailsBussinessLogic.GetUserEducationDetails();
        }

        [Route("GetUserEducationDetailsById/{id}")]
        [HttpGet]
        public async Task<UserEducationDetail> GetUserEducationDetailsById(int id)
        {
            return await userEducationDetailsBussinessLogic.GetUserEducationDetailsById(id);
        }


        [Route("DeleteUserEducationDetails/{id}")]
        [HttpDelete]
        public async Task<int> DeleteUserEducationDetail(int id)
        {
            return await userEducationDetailsBussinessLogic.DeleteUserEducationDetail(id);
        }

      
        [Route("AddUserEducationDetail")]
        [HttpPost]
        public async Task<int> AddUserEducationDetail(UserEducationDetail user)
        {
            return await userEducationDetailsBussinessLogic.InsertUserEducationDetail(user);
        }

        [Route("AddUserEducationDetails")]
        [HttpPost]
        public async Task<int> InsertUserEducationDetails(List<UserEducationDetail> userEducationDetails)
        {
            return await userEducationDetailsBussinessLogic.InsertUserEducationDetails(userEducationDetails);
        }

        [Route("UpdateUserEducationDetail")]
        [HttpPut]
        public async Task<int> UpdateUserEducationDetail(UserEducationDetail user)
        {
            return await userEducationDetailsBussinessLogic.UpdateUserEducationDetail(user);
        }

        [Route("UpdateUserEducationDetails")]
        [HttpPut]
        public async Task<int> UpdateUserEducationDetails(List<UserEducationDetail> user)
        {
            return await userEducationDetailsBussinessLogic.UpdateUserEducationDetails(user);
        }

        [Route("AddUpdateUserEducationDetail")]
        [HttpPut]
        public async Task<int> AddUpdateUserEducationDetail(UserEducationDetail userEducationDetail)
        {
            if (userEducationDetail == null)
            {
                var data = userEducationDetail.Id > 0 ? await userEducationDetailsBussinessLogic.UpdateUserEducationDetail(userEducationDetail) : await userEducationDetailsBussinessLogic.InsertUserEducationDetail(userEducationDetail);
            }
            return 1;
        }

        [Route("AddOrUpdateUserEducationDetails")]
        [HttpPut]
        public async Task<int> AddOrUpdateUserAddressDetails(List<UserEducationDetail> userAddressDetails)
        {
            if (userAddressDetails == null)
            {
                await userEducationDetailsBussinessLogic.UpdateUserEducationDetails(userAddressDetails.Where(ad => ad.Id > 0).ToList());
                await userEducationDetailsBussinessLogic.InsertUserEducationDetails(userAddressDetails.Where(ad => ad.Id < 1).ToList());

            }
            return 1;
        }


    }
}

