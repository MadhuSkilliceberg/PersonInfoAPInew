using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionRepository : IInstitutionRepository
    {
        private PersonsInfoV3NewContext context;

        public InstitutionRepository(PersonsInfoV3NewContext context)
        {
            this.context = context;
        }

        public async Task<int> DeleteInstitutionByInstitutionId(int institutionId)
        {
            var k = context.Institutions.Where(a => a.Id == institutionId).FirstOrDefault();
            context.Institutions.Remove(k);
           await context.SaveChangesAsync();
            return 1;
        }

        public async Task<Institution> GetInstitutionByInstitutionId(int institutionId)
        {
            var k =await context.Institutions.Where(a => a.Id == institutionId).FirstOrDefaultAsync();
            return k;
        }

        public async Task<List<Institution>> GetInstitutions()
        {
            return await context.Institutions.ToListAsync();
        }

        public async Task<int> AddInstitution(Institution institution)
        {
            try
            {
                context.Institutions.Add(institution);
               await context.SaveChangesAsync();
                return institution.Id;
            }
            catch(Exception ex)
            {
                return 0;
            }
           
        }

        public async Task<int> UpdateInstitution(Institution institution)
        {
            context.Institutions.Update(institution);
          await  context.SaveChangesAsync();
            return institution.Id;
        }

       



        //public int InsertInstitutionlist(Qualificationcs qualificationcsss)
        //{
        //    Context.Institutions.Add(qualificationcsss);
        //    Context.SaveChanges();
        //    return qualificationcsss.Id;
        //}
    }
}
