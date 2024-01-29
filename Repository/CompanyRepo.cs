using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class CompanyRepo : ICompanyRepo
    {
        PersonsInfoV3NewContext Context = new PersonsInfoV3NewContext();



        public int DeleteCompany(int id)
        {
            var k = Context.Companies.Where(a => a.Id == id).FirstOrDefault();
            Context.Companies.Remove(k);
            Context.SaveChanges();
            return 1;
        }

        public Company GetByCompanyId(int id)
        {
            var data = Context.Companies.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }

        public List<Company> GetCompany()
        {
            return Context.Companies.ToList();
        }

        public int InsertCompany(Company company)
        {
            Context.Companies.Add(company);
            Context.SaveChanges();
            return company.Id;
        }

        public int UpdateCompany(Company company)
        {
            Context.Companies.Update(company);
            Context.SaveChanges();
            return company.Id;
        }


       
    }
}
