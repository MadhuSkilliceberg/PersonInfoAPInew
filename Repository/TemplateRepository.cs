using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class TemplateRepository : ITemplateRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();
        public int DeleteTemplate(int id)
        {
            var a = person.Templates.Where(c => c.Id == id).FirstOrDefault();
            person.Templates.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public Template GetByTemplateId(int id)
        {
            return person.Templates.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Template> GetTemplates()
        {
            return person.Templates.ToList();
        }

        public int InsertTemplate(Template Template)
        {
            person.Templates.Add(Template);
            person.SaveChanges();
            return Template.Id;

        }

        public bool UpdateTemplate(Template Template)
        {
            person.Templates.Update(Template);
            person.SaveChanges();
            return true;
        }
    }
}
