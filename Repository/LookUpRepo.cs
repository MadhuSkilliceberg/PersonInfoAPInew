using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace PersonsInfoV2Api.Repository
{
    public class LookUpRepo: ILookUpRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

        public int DeleteLookUp(int id)
        {
            var k = Context.LookUps.Where(a => a.Id == id).FirstOrDefault();
            Context.LookUps.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public LookUp GetByLookUpId(int id)
        {
            var k = Context.LookUps.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<LookUp> GetLookUps()
        {
            return Context.LookUps.ToList();
        }

        public bool InsertLookUp(LookUp LookUp)
        {
            Context.LookUps.Add(LookUp);
            Context.SaveChanges();
            return true;
        }

        public bool UpdateLookUp(LookUp LookUp)
        {
            Context.LookUps.Update(LookUp);
            Context.SaveChanges();
            return true;
        }

        public object GetLookUps1()
        {
            var result = (Context.LookUps.Select(lookup => new
            {
                Id = lookup.Id,
                Name = lookup.Name,
                Value = Context.LookUpValues
                .Where(lookupValue => lookupValue.LookUpId == lookup.Id)
                .Select(lookupValue => new
                {
                    Id = lookupValue.Id,
                    Name = lookupValue.Name
                }).ToList()
            })).ToList();
            return result;
        }
    }
}
