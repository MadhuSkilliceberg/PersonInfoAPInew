using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly PersonsInfoV3NewContext context;

        public CompanyRepository(PersonsInfoV3NewContext personsInfoV3NewContext)
        {
            context = personsInfoV3NewContext;
        }

        public async Task<int> AddCompany(Company company)
        {
            await context.Companies.AddAsync(company);
            await context.SaveChangesAsync();
            return company.Id;
        }

        public async Task<int> AddRangeCompany(List<Company> companies)
        {
            await context.Companies.AddRangeAsync(companies);
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<bool> DeleteCompany(int id)
        {

            context.Companies.Remove(await context.Companies.Where(a => a.Id == id).FirstOrDefaultAsync());
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteRangeCompany(List<int> ids)
        {
            context.Companies.RemoveRange(await context.Companies.Where(a => ids.Contains(a.Id)).ToListAsync());
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await context.Companies.ToListAsync();
        }

        public async Task<Company> GetCompanyById(int id)
        {
            return await context.Companies.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateCompany(Company company)
        {
            context.Companies.Update(company);
            await context.SaveChangesAsync();
            return company.Id;
        }
        public async Task<int> UpdateRangeCompany(List<Company> companies)
        {
            context.Companies.UpdateRange(companies);
            await context.SaveChangesAsync();
            return 1;
        }
    }
}
