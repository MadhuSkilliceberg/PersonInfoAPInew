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
    public class UserAddressDetailController : ControllerBase
    {
        IUserAddressDetailBusinessLogic userAddressDetailBusinessLogic;

        public  UserAddressDetailController(IUserAddressDetailBusinessLogic Repo)
        {
            userAddressDetailBusinessLogic = Repo;
        }

        [Route("DeleteUserAddressDetailById/{id}")]
        [HttpDelete]
        public async Task<int> DeleteUserAddressDetailById(int id)
        {
            return await userAddressDetailBusinessLogic.DeleteUserAddressDetailById(id);
        }


        [Route("GetUserAddressDetailsById/{id}")]
        [HttpGet]
        public async Task<UserAddressDetail> GetUserAddressDetailById(int id)
        {
            return await userAddressDetailBusinessLogic.GetUserAddressDetailById(id);
        }

        [Route("GetUserAddressDetailsByUserId/{id}")]
        [HttpGet]
        public async Task<List<UserAddressDetail>> GetUserAddressDetailsByUserId(int id)
        {
            return await userAddressDetailBusinessLogic.GetUserAddressDetailsByUserId(id);
        }

         


        [Route("GetUserAddressDetails")]
        [HttpGet]
        public async Task<List<UserAddressDetail>> GetUserAddressDetails()
        {
            return await userAddressDetailBusinessLogic.GetUserAddressDetails();
        }

        [Route("AddUserAddressDetail")]
        [HttpPost]
        public async Task<int> AddUserAddressDetail(UserAddressDetail userAddressDetail)
        {
            return await userAddressDetailBusinessLogic.AddUserAddressDetail(userAddressDetail);
        }


        [Route("UpdateUserAddressDetail")]
        [HttpPut]
        public async Task<int> UpdateUserAddressDetail(UserAddressDetail user)
        {
            return await userAddressDetailBusinessLogic.UpdateUserAddressDetail(user);
        }

        [Route("AddUpdateUserAddressDetail")]
        [HttpPut]
        public async Task<int> AddUpdateUserAddressDetail(UserAddressDetail userAddressDetail)
        {
            if (userAddressDetail == null)
            {
              var data=  userAddressDetail.Id >0 ? await userAddressDetailBusinessLogic.UpdateUserAddressDetail(userAddressDetail): await userAddressDetailBusinessLogic.AddUserAddressDetail(userAddressDetail);
            }
            return 1;
        }

        [Route("AddOrUpdateUserAddressDetails")]
        [HttpPut]
        public async Task<int> AddOrUpdateUserAddressDetails(List<UserAddressDetail> userAddressDetails)
        {
            if (userAddressDetails == null)
            {
                await userAddressDetailBusinessLogic.UpdateUserAddressDetails(userAddressDetails.Where(ad => ad.Id > 0).ToList());
                await userAddressDetailBusinessLogic.AddUserAddressDetails(userAddressDetails.Where(ad=>ad.Id<1).ToList()); 
               
            }
            return 1;
        }

    }
}
