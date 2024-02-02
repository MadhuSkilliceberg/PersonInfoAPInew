using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface IIndustryTypeRepository
    {
        public List<IndustryType> GetIndustryTypes();
        public int InsertIndustryType(IndustryType IndustryType);

        public bool UpdateIndustryType(IndustryType IndustryType);

        public int DeleteIndustryType(int id);

        public IndustryType GetByIndustryTypeId(int id);


    }
}
