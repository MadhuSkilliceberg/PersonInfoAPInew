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
            var k = await context.Institutions.Where(a => a.Id == institutionId).FirstOrDefaultAsync();
            return k;
        }

        public async Task<List<Institution>> GetInstitutions()
        {
            var query =
   from Institution in context.Institutions
   join qulificationTypes in context.QulificationTypes on Institution.QulificationTypeId equals qulificationTypes.Id
   join mediam in context.Media on Institution.MediumId equals mediam.Id
   //  where post.ID == id
   select new Institution
   {
       Id = Institution.Id,
       InstitutionName = Institution.InstitutionName,
       //   QulificationTypeName = qulificationTypes.Name,
       // MediumName = mediam.Name,
   };
            return query.ToList();
            // return await context.Institutions.ToListAsync();
        }

        public async Task<int> AddInstitution(Institution institution)
        {
            try
            {
                context.Institutions.Add(institution);
                await context.SaveChangesAsync();
                return institution.Id;
            }
            catch 
            {
                return 0;
            }

        }

        public async Task<int> UpdateInstitution(Institution institution)
        {
            context.Institutions.Update(institution);
            await context.SaveChangesAsync();
            return institution.Id;
        }


        public async Task<List<Institution>> GetUniversities(int id)
        {
            if (id > 0)
                return await context.Institutions.Where(i =>  i.ParentId == id).ToListAsync();
            else
                return await context.Institutions.Where(i => i.ParentId==null).ToListAsync();
        }


        //public int InsertInstitutionlist(Qualificationcs qualificationcsss)
        //{
        //    Context.Institutions.Add(qualificationcsss);
        //    Context.SaveChanges();
        //    return qualificationcsss.Id;
        //}
    }
}
