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
    public class UserCompanyController : ControllerBase
    {
        IUserCompanyBusinessLogic usercompany;

        public  UserCompanyController(IUserCompanyBusinessLogic Repo)
        {
            usercompany = Repo;
        }


        [Route("GetUserCompanies")]
        [HttpGet]
        public async Task<List<UserCompany>> GetUserCompanies()
        {
            return await usercompany.GetUserCompanies();
        }


        [Route("GetUserCompanyById/{id}")]
        [HttpGet]
        public async Task<UserCompany> GetUserCompanyById(int id)
        {
            return await usercompany.GetUserCompanyById(id);
        }

        [Route("AddUserCompany")]
        [HttpPost]
        public async Task<int> AddUserCompany(UserCompany user)
        {
            return await usercompany.AddUserCompany(user);
        }

        [Route("AddUserCompanies")]
        [HttpPost]
        public async Task<int> AddUserCompanies(List<UserCompany> userCompanies)
        {
            return await usercompany.AddUserCompanies(userCompanies);
        }

        [Route("UpdateUserCompany")]
        [HttpPut]
        public async Task<int> UpdateUserCompany(UserCompany userCompany)
        {
            return await usercompany.UpdateUserCompany(userCompany);
        }

        [Route("UpdateUserCompanies")]
        [HttpPut]
        public async Task<int> UpdateUserCompanies(List<UserCompany> userCompanies)
        {
            return await usercompany.UpdateUserCompanies(userCompanies);
        }

        [Route("DeleteUserCompanyById/{id}")]
        [HttpDelete]
        public async Task<int> DeleteUserCompanyById(int id)
        {
            return await usercompany.DeleteUserCompanyById(id);
        }

        [Route("AddUpdateUserAddressDetail")]
        [HttpPut]
        public async Task<int> AddUpdateUserAddressDetail(UserCompany userCompany)
        {
            if (userCompany == null)
            {
                var data = userCompany.Id > 0 ? await usercompany.UpdateUserCompany(userCompany) : await usercompany.AddUserCompany(userCompany);
            }
            return 1;
        }

        [Route("AddOrUpdateUserAddressDetails")]
        [HttpPut]
        public async Task<int> AddOrUpdateUserAddressDetails(List<UserCompany> userCompanies)
        {
            if (userCompanies == null)
            {
                await usercompany.UpdateUserCompanies(userCompanies.Where(ad => ad.Id > 0).ToList());
                await usercompany.AddUserCompanies(userCompanies.Where(ad => ad.Id < 1).ToList());

            }
            return 1;
        }

    }
}
