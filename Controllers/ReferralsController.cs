using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonsInfoV2Api.BussinessLogic;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;

namespace PersonsInfoV2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferralsController : ControllerBase
        
    {
        IReferralBussinessLogic referralBussinessLogic;
        public ReferralsController(IReferralBussinessLogic Repo)
        {
            referralBussinessLogic = Repo;
        }


        [Route("DeleteReferralss/{id}")]
        [HttpDelete]
        public int DeleteReferrals(int id)
        {
            return referralBussinessLogic.DeleteReferral(id);
        }


        [Route("GetReferralssById/{id}")]
        [HttpGet]
        public Referral GetByReferralsId(int id)
        {
            return referralBussinessLogic.GetByReferralId(id);
        }


        [Route("GetReferrals")]
        [HttpGet]
        public List<Referral> GetReferrals()
        {
            return referralBussinessLogic.GetReferrals();
        }


        [Route("AddReferralss")]
        [HttpPost]
        public int InsertReferrals(Referral referral)
        {
            return referralBussinessLogic.InsertReferral(referral);
        }


        [Route("UpdateReferralss")]
        [HttpPut]
        public int UpdateReferrals(Referral referral)
        {
            return referralBussinessLogic.UpdateReferral(referral);
        }



     

        // GET: api/Referrals/5
        [Route("GetReferralByRefferedCode/{code}")]
        [HttpGet]
        public async Task<List<Referral>> GetReferralByRefferedCode(string code)
        {
            try
            {
                return await referralBussinessLogic.GetReferralByRefferedCode(code);
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    } }
     
