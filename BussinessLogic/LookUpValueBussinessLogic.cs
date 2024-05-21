using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class LookUpValueBussinessLogic: ILookUpValueBussinessLogic
    {
        ILookUpValueRepo LookUpValueRepository;
        public LookUpValueBussinessLogic(ILookUpValueRepo Repo)
        {
            LookUpValueRepository = Repo;
        }

        public int DeleteLookUpValue(int id)
        {
            return LookUpValueRepository.DeleteLookUpValue(id);
        }

        public LookUpValue GetByLookUpValueId(int id)
        {
            return LookUpValueRepository.GetByLookUpValueId(id);
        }

        public List<LookUpValue> GetLookUpValues()
        {
            return LookUpValueRepository.GetLookUpValues();
        }

        public List<LookUpValue> GetLookUpValueByCode(List<string> codes)
        {
            return LookUpValueRepository.GetLookUpValueByCode(codes);
        }

        public List<LookUpValue> GetLookUpValueByLId(int Id)
        {
            return LookUpValueRepository.GetLookUpValueByLId(Id);
        }
        public bool InsertLookUpValue(LookUpValue LookUpValue)
        {
            return LookUpValueRepository.InsertLookUpValue(LookUpValue);
        }

        public bool UpdateLookUpValue(LookUpValue LookUpValue)
        {
            return LookUpValueRepository.UpdateLookUpValue(LookUpValue);
        }
    }
}
