using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class ReferralsBussinessLogic : IReferralBussinessLogic
    {
        IReferralRepo referralRepository;
        public ReferralsBussinessLogic(IReferralRepo Repo)
        {
            referralRepository = Repo;
        }

        public int DeleteReferral(int id)
        {
            return referralRepository.DeleteReferral(id);
        }

        public Referral GetByReferralId(int id)
        {

            return referralRepository.GetReferralById(id);
        }

        public List<Referral> GetReferrals()
        {
            return referralRepository.GetReferrals();
        }

        public int InsertReferral(Referral referral)
        {
            return referralRepository.InsertReferral(referral);
        }

        public int UpdateReferral(Referral referral)
        {
            return referralRepository.UpdateReferral(referral);

        }





        public async Task<List<Referral>> GetReferralByRefferedCode(string code)
        {
            return await referralRepository.GetReferralByRefferedCode(code);
        }
    }
}
