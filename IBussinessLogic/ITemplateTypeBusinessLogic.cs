using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
  public  interface ITemplateTypeBusinessLogic
    {
        public List<TemplateType> GetTemplateTypes();
        public int InsertTemplateType(TemplateType TemplateType);

        public bool UpdateTemplateType(TemplateType TemplateType);

        public int DeleteTemplateType(int id);

        public TemplateType GetByTemplateTypeId(int id);

    }
}
