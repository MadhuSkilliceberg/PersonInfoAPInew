using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class LookUpValueRepo: ILookUpValueRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteLookUpValue(int id)
        {
            var k = Context.LookUpValues.Where(a => a.Id == id).FirstOrDefault();
            Context.LookUpValues.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public LookUpValue GetByLookUpValueId(int id)
        {
            var k = Context.LookUpValues.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<LookUpValue> GetLookUpValues()
        {
            return Context.LookUpValues.ToList();
        }

        public bool InsertLookUpValue(LookUpValue LookUpValue)
        {
            Context.LookUpValues.Add(LookUpValue);
            Context.SaveChanges();
            return true;
        }

        public bool UpdateLookUpValue(LookUpValue LookUpValue)
        {
            Context.LookUpValues.Update(LookUpValue);
            Context.SaveChanges();
            return true;
        }
    }
}
