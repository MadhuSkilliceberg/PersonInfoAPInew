using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ITemplateBusinessLogic
    {
        public List<Template> GetTemplates();
        public int InsertTemplate(Template Template);

        public bool UpdateTemplate(Template Template);

        public int DeleteTemplate(int id);

        public Template GetByTemplateId(int id);

    }
}
