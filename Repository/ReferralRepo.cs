using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class ReferralRepo : IReferralRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteReferral(int id)
        {
            var k = Context.Referrals.Where(a => a.Id == id).FirstOrDefault();
            Context.Referrals.Remove(k);
            Context.SaveChanges();
            return 1;
        }

      

        public List<Referral> GetReferrals()
        {
            return Context.Referrals.ToList();
        }

        public int InsertReferral(Referral user)
        {
            Context.Referrals.Add(user);
            Context.SaveChanges();
            return user.Id;
        }

        public int UpdateReferral(Referral user)
        {
            Context.Referrals.Update(user);
            Context.SaveChanges();
            return user.Id;
        }

        
        public Referral GetReferralById(int id)
        {
            var k = Context.Referrals.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }


        public async Task<List<Referral>> GetReferralByRefferedCode(string code)
        {
            return await Context.Referrals.Where(a => a.RefferalCode == code).ToListAsync();

        }
    }
}
