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
    public class CompanyAddressController : ControllerBase
    {
        public readonly ICompanyAddressBussinessLogic companyAddressBussinessLogic;
        public CompanyAddressController(ICompanyAddressBussinessLogic companyAddressBussinessLogic)
        {
            this.companyAddressBussinessLogic = companyAddressBussinessLogic;
        }

        [Route("DeleteCompanyAddress/{companyAddressId}")]
        [HttpDelete]
        public async Task<int> DeleteCompanyAddress(int companyAddressId)
        {
            return await companyAddressBussinessLogic.DeleteCompanyAddress(companyAddressId);
        }

        [Route("DeleteRangeCompanyAddress")]
        [HttpDelete]
        public async Task<int> DeleteRangeCompanyAddress(List<int> companyAddressIds)
        {
            return await companyAddressBussinessLogic.DeleteRangeCompanyAddress(companyAddressIds);
        }


        [Route("GetCompanyAddressByCompanyAddressId/{companyAddressId}")]
        [HttpGet]
        public async Task<CompanyAddress> GetCompanyAddressByCompanyAddressId(int companyAddressId)
        {
            return await companyAddressBussinessLogic.GetCompanyAddressByCompanyAddressId(companyAddressId);
        }


        [Route("GetCompanyAddresses")]
        [HttpGet]
        public async Task<List<CompanyAddress>> GetCompanyAddresses()
        {
            return await companyAddressBussinessLogic.GetCompanyAddresses();
        }


        [Route("AddCompanyAddress")]
        [HttpPost]
        public async Task<int> AddCompanyAddress(CompanyAddress companyAddress)
        {
            return await companyAddressBussinessLogic.AddCompanyAddress(companyAddress);
        }

        [Route("AddRangeCompanyAddress")]
        [HttpPost]
        public async Task<List<int>> AddRangeCompanyAddress(List<CompanyAddress> companyAddresses)
        {
            return await companyAddressBussinessLogic.AddRangeCompanyAddress(companyAddresses);
        }


        [Route("UpdateCompanyAddress")]
        [HttpPut]
        public async Task<bool> UpdateCompanyAddress(CompanyAddress companyAddress)
        {
            return await companyAddressBussinessLogic.UpdateCompanyAddress(companyAddress);
        }

        [Route("UpdateRangeCompanyAddress")]
        [HttpPut]
        public async Task<bool> UpdateRangeCompanyAddress(List<CompanyAddress> companyAddresses)
        {
            return await companyAddressBussinessLogic.UpdateRangeCompanyAddress(companyAddresses);
        }


        [Route("GetCompanyAddressIdByCompanyId/{companyid}")]
        [HttpGet]
        public async Task<List<CompanyAddress>> GetCompanyAddressesByCompanyId(int companyId)
        {
            return await companyAddressBussinessLogic.GetCompanyAddressesIdByCompanyId(companyId);

        }


    }
}
