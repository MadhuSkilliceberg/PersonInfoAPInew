using PersonsInfoV2Api.Entities;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
    public interface ICyearRepo
    {
        public List<Cyear> GetCyears();
        public int InsertCyear(Cyear cyear);

        public int UpdateCyear(Cyear cyear);

        public int DeleteCyear(int id);

        public Cyear GetByCyearId(int id);


    }
}
