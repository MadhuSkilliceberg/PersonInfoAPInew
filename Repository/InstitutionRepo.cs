using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonsInfoV2Api.CoustumModels;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionRepo : IInstitutionRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();

      
        public int DeleteInstitution(int id)
        {
            var k = Context.Institutions.Where(a => a.Id == id).FirstOrDefault();
            Context.Institutions.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Institution GetByInstitutionId(int id)
        {
            var k = Context.Institutions.Where(a => a.Id == id).FirstOrDefault();
            return k;
        }

        public List<Institution> GetInstitutions()
        {
            return Context.Institutions.ToList();
        }

        public int InsertInstitution(Institution institution)
        {
            try
            {
                Context.Institutions.Add(institution);
                Context.SaveChanges();
                return institution.Id;
            }
            catch(Exception ex)
            {
                return 0;
            }
           
        }

        public int UpdateInstitution(Institution institution)
        {
            Context.Institutions.Update(institution);
            Context.SaveChanges();
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
