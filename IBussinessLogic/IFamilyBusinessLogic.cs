using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
   public interface IFamilyBusinessLogic
    {
        public List<Family> GetFamilies();
        public bool InsertFamily(Family family);
        public bool UpdateFamily(Family family);
        public bool DeleteFamily(int id);
        public Family GetById(int id);
    }
}
