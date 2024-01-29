using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class TemplateBusinessLogic: ITemplateBusinessLogic
    {
        ITemplateRepo TemplateRepo;

        public  TemplateBusinessLogic(ITemplateRepo Repo)
        {
            TemplateRepo = Repo;
        }

        public int DeleteTemplate(int id)
        {
            return TemplateRepo.DeleteTemplate(id);
        }

        public Template GetByTemplateId(int id)
        {
            return TemplateRepo.GetByTemplateId(id);
        }

        public List<Template> GetTemplates()
        {
            return TemplateRepo.GetTemplates();
        }

        public int InsertTemplate(Template Template)
        {
            return TemplateRepo.InsertTemplate(Template);
        }

        public bool UpdateTemplate(Template Template)
        {
            return TemplateRepo.UpdateTemplate(Template);
        }
    }
}
