using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class TemplateTypeRepository : ITemplateTypeRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteTemplateType(int id)
        {
            var a = person.TemplateTypes.Where(c => c.Id == id).FirstOrDefault();
            person.TemplateTypes.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public TemplateType GetByTemplateTypeId(int id)
        {
            return person.TemplateTypes.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<TemplateType> GetTemplateTypes()
        {
            return person.TemplateTypes.ToList();
        }

        public int InsertTemplateType(TemplateType TemplateType)
        {
            person.TemplateTypes.Add(TemplateType);
            person.SaveChanges();
            return TemplateType.Id;

        }

        public bool UpdateTemplateType(TemplateType TemplateType)
        {
            person.TemplateTypes.Update(TemplateType);
            person.SaveChanges();
            return true;
        }
    }
}
