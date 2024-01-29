using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IInstitutionRepo
    {
        public List<Institution> GetInstitutions();
        public int InsertInstitution(Institution institution);

        public int UpdateInstitution(Institution institution);

        public int DeleteInstitution(int id);

        public Institution GetByInstitutionId(int id);



    }
}
