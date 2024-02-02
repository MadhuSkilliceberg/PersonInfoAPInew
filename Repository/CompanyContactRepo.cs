using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class CompanyContactRepo : ICompanyContactRepository
    {
        private readonly PersonsInfoV3NewContext context;

        public CompanyContactRepo(PersonsInfoV3NewContext personsInfoV3NewContext)
        {
            this.context = personsInfoV3NewContext;
        }

        public async Task<List<CompanyContact>> GetCompanyContacts()
        {
            return await context.CompanyContacts.ToListAsync();
           // return await context.CompanyContacts.Where(i => i.CompanyAddressId == companyaddressId).ToListAsync();
        }
        public async Task<CompanyContact> GetCompanyContactById(int id)
        {
           return await context.CompanyContacts.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> AddCompanyContact(CompanyContact companyContact)
        {
            await context.CompanyContacts.AddAsync(companyContact);
            await context.SaveChangesAsync();
            return companyContact.Id;
        }

        public async Task<int> AddRanageCompanyContact(List<CompanyContact> companyContacts)
        {
            try
            {
                if (companyContacts != null)
                {
                    await context.CompanyContacts.AddRangeAsync(companyContacts);
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

       public async Task<int>  UpdateCompanyContact(CompanyContact companyContact)
        {
             context.CompanyContacts.Update(companyContact);
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> UpdateRangeCompanyContact(List<CompanyContact> companyContacts)
        {
            try
            {
                if (companyContacts != null)
                {
                     context.CompanyContacts.UpdateRange(companyContacts);
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

        public async Task<bool> DeleteCompanyContact(int id)
        {
            context.CompanyContacts.Remove(await context.CompanyContacts.Where(a => a.Id == id).FirstOrDefaultAsync());
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteRangeCompanyContact(List<int> ids)
        {
            context.CompanyContacts.RemoveRange(await context.CompanyContacts.Where(x => ids.Contains(x.Id)).ToListAsync());
            await context.SaveChangesAsync();
            return true;
        }

       public async Task<int> AddRangeCompanyContact(List<CompanyContact> companyContacts)
        {
            await context.CompanyContacts.AddRangeAsync(companyContacts);
            await context.SaveChangesAsync();
            return 1;
        }

       public async Task<List<CompanyContact>> GetCompanyContactByCompanyAddressId(int companyaddressId)
        {
            return await context.CompanyContacts.Where(i => i.CompanyAddressId == companyaddressId).ToListAsync();
        }

    }
}
