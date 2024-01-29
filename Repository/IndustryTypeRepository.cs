using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class IndustryTypeRepository : IIndustryTypeRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteIndustryType(int id)
        {
            var a = person.IndustryTypes.Where(c => c.Id == id).FirstOrDefault();
            person.IndustryTypes.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public IndustryType GetByIndustryTypeId(int id)
        {
            return person.IndustryTypes.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<IndustryType> GetIndustryTypes()
        {
            return person.IndustryTypes.ToList();
        }

        public int InsertIndustryType(IndustryType IndustryType)
        {
            person.IndustryTypes.Add(IndustryType);
            person.SaveChanges();
            return IndustryType.Id;

        }

        public bool UpdateIndustryType(IndustryType IndustryType)
        {
            person.IndustryTypes.Update(IndustryType);
            person.SaveChanges();
            return true;
        }
    }
}
