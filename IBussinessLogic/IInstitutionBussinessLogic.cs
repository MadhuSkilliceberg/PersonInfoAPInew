using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.IBussinessLogic
{
   public interface IInstitutionBussinessLogic
    {
        //public Task<List<Institution>> GetInstitutions();
        //public Task<int> InsertInstitution(Institution institution);

        //public Task<int> UpdateInstitution(Institution institution);

        //public Task<int> DeleteInstitution(int id);

        //public Task<Institution> GetByInstitutionId(int id);
        public Task<List<Qualificationcs>> GetQualificationcs();

        public Task<bool> InstitutionModel (InstitutionModels institutionModels);
        public Task<bool> InstitutionDetails (InstitutionDetails institutionDetails);



        public Task<List<Institution>> GetInstitutions();
        public Task<int> AddInstitution(Institution institution);

        public Task<int> UpdateInstitution(Institution institution);

        public Task<int> DeleteInstitutionByInstitutionId(int institutionId);

        public Task<Institution> GetInstitutionByInstitutionId(int institutionId);



    }
}
