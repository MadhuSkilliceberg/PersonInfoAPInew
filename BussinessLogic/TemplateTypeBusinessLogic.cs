using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class TemplateTypeBusinessLogic: ITemplateTypeBusinessLogic
    {
        ITemplateTypeRepo TemplateTypeRepo;

        public  TemplateTypeBusinessLogic(ITemplateTypeRepo Repo)
        {
            TemplateTypeRepo = Repo;
        }

        public int DeleteTemplateType(int id)
        {
            return TemplateTypeRepo.DeleteTemplateType(id);
        }

        public TemplateType GetByTemplateTypeId(int id)
        {
            return TemplateTypeRepo.GetByTemplateTypeId(id);
        }

        public List<TemplateType> GetTemplateTypes()
        {
            return TemplateTypeRepo.GetTemplateTypes();
        }

        public int InsertTemplateType(TemplateType TemplateType)
        {
            return TemplateTypeRepo.InsertTemplateType(TemplateType);
        }

        public bool UpdateTemplateType(TemplateType TemplateType)
        {
            return TemplateTypeRepo.UpdateTemplateType(TemplateType);
        }
    }
}
