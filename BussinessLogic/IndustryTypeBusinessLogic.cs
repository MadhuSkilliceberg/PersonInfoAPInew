using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class IndustryTypeBusinessLogic: IIndustryTypeBusinessLogic
    {
        IIndustryTypeRepository IndustryTypeRepo;

        public  IndustryTypeBusinessLogic(IIndustryTypeRepository Repo)
        {
            IndustryTypeRepo = Repo;
        }

        public int DeleteIndustryType(int id)
        {
            return IndustryTypeRepo.DeleteIndustryType(id);
        }

        public IndustryType GetByIndustryTypeId(int id)
        {
            return IndustryTypeRepo.GetByIndustryTypeId(id);
        }

        public List<IndustryType> GetIndustryTypes()
        {
            return IndustryTypeRepo.GetIndustryTypes();
        }

        public int InsertIndustryType(IndustryType IndustryType)
        {
            return IndustryTypeRepo.InsertIndustryType(IndustryType);
        }

        public bool UpdateIndustryType(IndustryType IndustryType)
        {
            return IndustryTypeRepo.UpdateIndustryType(IndustryType);
        }
    }
}
