using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class CyearRepository :ICyearRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteCyear(int id)
        {
            var a = person.Cyears.Where(c => c.Id == id).FirstOrDefault();
            person.Cyears.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Cyear GetByCyearId(int id)
        {
            return person.Cyears.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Cyear> GetCyears()
        {
            return person.Cyears.ToList();
        }

        public int InsertCyear(Cyear cyear)
        {
            person.Cyears.Add(cyear);
            person.SaveChanges();
            return cyear.Id;

        }

        public int UpdateCyear(Cyear cyear)
        {
            person.Cyears.Update(cyear);
            person.SaveChanges();
            return cyear.Id;
        }
    }
}
