using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface ILookUpRepo
    {
        public List<LookUp> GetLookUps();
        public bool InsertLookUp(LookUp LookUp);

        public bool UpdateLookUp(LookUp LookUp);

        public int DeleteLookUp(int id);

        public LookUp GetByLookUpId(int id);

        public object GetLookUps1();
    }
}
