using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IRepository
{
   public interface IInstitutionRepository
    {
        public Task<List<Institution>> GetInstitutions();
        public Task<int> AddInstitution(Institution institution);

        public Task<int> UpdateInstitution(Institution institution);

        public Task<int> DeleteInstitutionByInstitutionId(int institutionId);

        public Task<Institution> GetInstitutionByInstitutionId(int institutionId);

        public  Task<List<Institution>> GetUniversities(int id);

    }
}
