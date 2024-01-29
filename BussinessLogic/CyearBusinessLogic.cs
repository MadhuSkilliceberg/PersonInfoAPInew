using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CyearBusinessLogic : ICyearBusinessLogic
    {
        ICyearRepo CyearRepo;

        public CyearBusinessLogic(ICyearRepo Repo)
        {
            CyearRepo = Repo;
        }

        public int DeleteCyear(int id)  
        {
            return CyearRepo.DeleteCyear(id);
        }

        public Cyear GetByCyearId(int id)
        {
            return CyearRepo.GetByCyearId(id);
        }

        public List<Cyear> GetCyears()
        {
            return CyearRepo.GetCyears();
        }

        public int InsertCyear(Cyear cyear)
        {
            return CyearRepo.InsertCyear(cyear);
        }

        public int UpdateCyear(Cyear cyear)
        {
            return CyearRepo.UpdateCyear(cyear);
        }
    }
}
