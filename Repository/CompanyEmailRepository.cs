using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonsInfoV2Api.CoustumModels;

namespace PersonsInfoV2Api.Repository
{
    public class CompanyEmailRepository : ICompanyEmailRepository
    {
        private readonly PersonsInfoV3NewContext context;

        public CompanyEmailRepository(PersonsInfoV3NewContext personsInfoV3NewContext)
        {
            context = personsInfoV3NewContext;
        }

        public async Task<List<CompanyEmail>> GetCompanyEmails()
        {
            return await context.CompanyEmails.ToListAsync();
        }

        public async Task<CompanyEmail> GetCompanyEmailById(int id)
        {
            return await context.CompanyEmails.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> AddCompanyEmail(CompanyEmail companyEmail)
        {
            await context.CompanyEmails.AddAsync(companyEmail);
            await context.SaveChangesAsync();
            return companyEmail.Id;
        }

        public async Task<int> AddRangeCompanyEmail(List<CompanyEmail> companyEmails)
        {
            try
            {
                if (companyEmails != null)
                {
                    await context.CompanyEmails.AddRangeAsync(companyEmails);
                    await context.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> UpdateCompanyEmail(CompanyEmail companyEmail)
        {
            context.CompanyEmails.Update(companyEmail);
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> UpdateRangeCompanyEmail(List<CompanyEmail> companyEmails)
        {
            context.CompanyEmails.UpdateRange(companyEmails);
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> DeleteCompanyEmail(int id)
        {
            context.CompanyEmails.Remove(await context.CompanyEmails.Where(a => a.Id == id).FirstOrDefaultAsync());
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> DeleteRangeCompanyEmail(List<int> ids)
        {
            context.CompanyEmails.RemoveRange(await context.CompanyEmails.Where(a => ids.Contains(a.Id)).ToListAsync());
            await context.SaveChangesAsync();
            return 1;
        }

       public async Task<List<CompanyEmail>> GetCompanyEmailByCompanyAddressId(int companyaddressId)
        {
            return await context.CompanyEmails.Where(a => a.CompanyAddressId == companyaddressId).ToListAsync();
        }
    }
}
