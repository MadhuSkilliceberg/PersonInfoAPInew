using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class FamilyEducationDetailRepository : IFamilyEducationDetailRepository
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteFamilyEducationDetail(int id)
        {
            var k = Context.FamilyEducationDetails.Where(a => a.Id == id).FirstOrDefault();
            Context.FamilyEducationDetails.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public FamilyEducationDetail GetById(int id)
        {
            var k = Context.FamilyEducationDetails.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<FamilyEducationDetail> GetFamilyEducationDetail()
        {
            return Context.FamilyEducationDetails.ToList();
        }

        public int InsertFamilyEducationDetail(FamilyEducationDetail detail)
        {
            Context.FamilyEducationDetails.Add(detail);
            Context.SaveChanges();
            return detail.Id;
        }

        public int UpdateFamilyEducationDetail(FamilyEducationDetail detail)
        {
            Context.FamilyEducationDetails.Update(detail);
            Context.SaveChanges();
            return detail.Id;
        }
    }
}
