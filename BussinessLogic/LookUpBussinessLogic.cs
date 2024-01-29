using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class LookUpBussinessLogic: ILookUpBussinessLogic
    {
        ILookUpRepo LookUpRepository;
        public LookUpBussinessLogic(ILookUpRepo Repo)
        {
            LookUpRepository = Repo;
        }

        public int DeleteLookUp(int id)
        {
            return LookUpRepository.DeleteLookUp(id);
        }

        public LookUp GetByLookUpId(int id)
        {
            return LookUpRepository.GetByLookUpId(id);
        }

        public List<LookUp> GetLookUps()
        {
            return LookUpRepository.GetLookUps();
        }

        public object GetLookUps1()
        {
            return LookUpRepository.GetLookUps1();
        }

     

        public bool InsertLookUp(LookUp LookUp)
        {
            return LookUpRepository.InsertLookUp(LookUp);
        }

        public bool UpdateLookUp(LookUp LookUp)
        {
            return LookUpRepository.UpdateLookUp(LookUp);
        }
    }
}
