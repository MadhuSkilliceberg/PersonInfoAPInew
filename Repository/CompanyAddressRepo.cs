using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class CompanyAddressRepo : ICompanyAddressRepository
    {
        private readonly PersonsInfoV3NewContext context;

        public CompanyAddressRepo(PersonsInfoV3NewContext personsInfoV3NewContext)
        {
            context = personsInfoV3NewContext;
        }

        //This method used for Get Company Addresses based on CompanyId
        public async Task<List<CompanyAddress>> GetCompanyAddressesIdByCompanyId(int companyId)
        {
            return await context.CompanyAddresses.Where(a => a.CompanyId == companyId).ToListAsync();
        }

        //This mmethod used for Add CompanyAddresses based on ther CompanyAddresses
        public async Task<List<int>> AddRangeCompanyAddress(List<CompanyAddress> companyAddresses)
        {
            try
            {
                if (companyAddresses != null)
                {
                    await context.CompanyAddresses.AddRangeAsync(companyAddresses);
                    await context.SaveChangesAsync();
                    return companyAddresses.Select(ca => ca.Id).ToList();
                }
                else
                {
                    return new List<int>();
                }
            }
            catch (Exception ex)
            {
                return new List<int>();
            }

        }

        //This method used for Update CompanyAddress based on the CompanyAddresses
        public async Task<bool> UpdateRangeCompanyAddress(List<CompanyAddress> companyAddresses)
        {
            try
            {
                if (companyAddresses != null)
                {
                    context.CompanyAddresses.UpdateRange(companyAddresses);
                    await context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //This method used to Delete CompanyAddress based on companyAddressId
        public async Task<int> DeleteCompanyAddress(int companyAddressId)
        {
            CompanyAddress companyAddress = await context.CompanyAddresses.Where(a => a.Id == companyAddressId).FirstOrDefaultAsync();
            context.CompanyAddresses.Remove(companyAddress);
            await context.SaveChangesAsync();
            return 1;
        }

        //This method used to Delete CompanyAddress based on companyAddressIds
        public async Task<int> DeleteRangeCompanyAddress(List<int> companyAddressIds)
        {
            context.CompanyAddresses.RemoveRange(await context.CompanyAddresses.Where(a => companyAddressIds.Contains(a.Id)).ToListAsync());
            await context.SaveChangesAsync();
            return 1;
        }

        //This method used to Get CompanyAddress based on companyAddressId
        public async Task<CompanyAddress> GetCompanyAddressByCompanyAddressId(int companyAddressId)
        {
            return await context.CompanyAddresses.Where(a => a.Id == companyAddressId).FirstOrDefaultAsync();
        }

        //This method used for Get CompanyAddresses 
        public async Task<List<CompanyAddress>> GetCompanyAddresses()
        {
            return await context.CompanyAddresses.ToListAsync();
        }

        //This method used for Add CompanyAddress based on the companyAddress
        public async Task<int> AddCompanyAddress(CompanyAddress companyAddress)
        {
            await context.CompanyAddresses.AddAsync(companyAddress);
            await context.SaveChangesAsync();
            return companyAddress.Id;
        }

        //This method used for Update CompanyAddress based on the CompanyAddress
        public async Task<bool> UpdateCompanyAddress(CompanyAddress companyAddress)
        {
            await context.CompanyAddresses.AddAsync(companyAddress);
            await context.SaveChangesAsync();
            return true;
        }
    }


}
