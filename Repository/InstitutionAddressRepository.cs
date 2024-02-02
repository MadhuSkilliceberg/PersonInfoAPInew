using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionAddressRepository : IInstitutionAddressRepository
    {
        PersonsInfoV3NewContext context;


        public InstitutionAddressRepository(PersonsInfoV3NewContext context)
        {
            this.context = context;

        }

        //Deleting Institution Address based on InstitutionAdressId
        public async Task<int> DeleteInstitutionAddressByInstitutionId(int institutionAdressId)

        {
            var k = await context.InstitutionAddresses.Where(a => a.Id == institutionAdressId).FirstOrDefaultAsync();
            context.InstitutionAddresses.Remove(k);
          await  context.SaveChangesAsync();
            return 1;
        }

        // Getting  Institution Address based on InstitutionAdressId
        public async Task<InstitutionAddress> GetInstitutionAddressByInstitutionAdressId(int institutionAdressId)
        {

            return await context.InstitutionAddresses.Where(a => a.Id == institutionAdressId).FirstOrDefaultAsync();
          
        }


        // Getting All Institution Addresses
        public async Task<List<InstitutionAddress>> GetInstitutionAddresses()
        {
            return await context.InstitutionAddresses.ToListAsync();
        }


        // Inserting  Institution Address 
        public async Task<int> AddInstitutionAddress(InstitutionAddress  institutionAddress)
        {
            context.InstitutionAddresses.Add(institutionAddress);
          await context.SaveChangesAsync();
            return institutionAddress.Id;
        }


        // Updating  Institution Address 
        public async Task<int> UpdateInstitutionAddress(InstitutionAddress institutionAddress)
        {
            context.InstitutionAddresses.Update(institutionAddress);
          await context.SaveChangesAsync();
            return institutionAddress.Id;
        }


        // Adding more than One Institution Address Details
        public async Task<bool> AddRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses)

        {
            try
            {
                if (institutionAddresses != null)
                {
                    context.InstitutionAddresses.AddRange(institutionAddresses);
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


        // Deleting  more than One Institution Address Details
        public async Task<bool> DeleteRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses)

        {
            try
            {
                if (institutionAddresses != null && institutionAddresses.Count>0)
                {
                    context.InstitutionAddresses.RemoveRange(institutionAddresses);
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


        //Updating more than One Institution Address Details 
        public async Task<bool> UpdateRangeInstitutionAddresses(List<InstitutionAddress> institutionAddresses)

        {
            try
            {
                if (institutionAddresses != null)
                {
                    context.InstitutionAddresses.UpdateRange(institutionAddresses);
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


        // Getting Institute Address based on InstituteId
        public async Task<List<InstitutionAddress>> GetInstitutionAddressByInstituteId(int instituteId)
        {
            return await context.InstitutionAddresses.Where(i =>i.InstitutionId == instituteId ).ToListAsync();
        }
    }
}
