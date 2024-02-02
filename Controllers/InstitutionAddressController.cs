using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;
using Microsoft.AspNetCore.Authorization;

namespace PersonsInfoV2Api.Controllers
{
   // [Authorize]
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionAddressController : ControllerBase
    {
     private readonly  IInstitutionAddressBusinessLogic _institutionAddressBusinessLogic;
        public InstitutionAddressController(IInstitutionAddressBusinessLogic institutionAddressBusinessLogic)
        {
            _institutionAddressBusinessLogic = institutionAddressBusinessLogic;
        }

        [Route("DeleteInstitutionAddressByInstitutionId/{institutionAdressId}")]
        [HttpDelete]
        public Task<int> DeleteInstitutionAddressByInstitutionId(int institutionAdressId)

        {
            return _institutionAddressBusinessLogic.DeleteInstitutionAddressByInstitutionId(institutionAdressId);
        }

        [Route("GetInstitutionAddressByInstitutionAdressId/{institutionAdressId}")]  
        [HttpGet]
        public async Task<InstitutionAddress> GetInstitutionAddressByInstitutionAdressId(int institutionAdressId)

        {
            return await _institutionAddressBusinessLogic.GetInstitutionAddressByInstitutionAdressId(institutionAdressId);
        }

        [Route("GetInstitutionAddresses")]
        [HttpGet]
        public async Task<List<InstitutionAddress>> GetInstitutionAddresses()
        {
            return await _institutionAddressBusinessLogic.GetInstitutionAddresses();
        }

        [Route("AddInstitutionAddress")]
        [HttpPost]
        public async Task<int> AddInstitutionAddress(InstitutionAddress institutionAddress)

        {
            return await _institutionAddressBusinessLogic.AddInstitutionAddress(institutionAddress);
        }

        [Route("UpdateInstitutionAddress")]
        [HttpPut]
        public async Task<int> UpdateInstitutionAddress(InstitutionAddress institutionAddress)

        {
            return await _institutionAddressBusinessLogic.UpdateInstitutionAddress(institutionAddress);
        }

        [Route("GetInstitutionAddresslist")]
        [HttpGet]
        public async Task<List<InstitutionAddresslist>> GetInstitutionAddresslist()
        {
            return await _institutionAddressBusinessLogic.GetInstitutionAddresslist();
        }

        [Route("GetInstitutionAddressByInstituteId/{instituteId}")]
        [HttpGet]
        public Task<List<InstitutionAddress>> GetInstitutionAddressByInstituteId(int instituteId)
        {
            return _institutionAddressBusinessLogic.GetInstitutionAddressByInstituteId(instituteId);
        }

        [Route("AddRangeInstitutionAddresses")]
        [HttpPost]
        public Task<bool> AddRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses)
        {
            return _institutionAddressBusinessLogic.AddRangeInstitutionAddresses(institutionAddresses);
        }

        [Route("UpdateRangeInstitutionAddresses")]
        [HttpPut]
        public Task<bool> UpdateRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses)
        {
            return _institutionAddressBusinessLogic.UpdateRangeInstitutionAddresses(institutionAddresses);
        }

        [Route("DeleteRangeInstitutionAddresses")]
        [HttpDelete]
        public Task<bool> DeleteRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses)
        {
            return _institutionAddressBusinessLogic.DeleteRangeInstitutionAddresses(institutionAddresses);
        }



    }

}
