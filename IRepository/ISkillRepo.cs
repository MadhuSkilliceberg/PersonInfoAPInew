using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
  public  interface IReferralRepo
    {
        public List<Referral> GetReferrals();
        public int InsertReferral(Referral user);

        public int UpdateReferral(Referral user);

        public int DeleteReferral(int id);

        public Referral GetReferralById(int id);

        public Task<List<Referral>> GetReferralByRefferedCode(string code);
    }
}
