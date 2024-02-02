using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionEmailRepository : IInstitutionEmailRepository
    {

        private readonly PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();



        public InstitutionEmailRepository(PersonsInfoV3NewContext context)
        {
            this.context = context;
        }


        // Deleting Institution Email based on InstitutionEmailId
        public async Task<int> DeleteInstitutionEmailByInstitutionEmailId(int institutionEmailId)

        {
            var k = context.InstitutionEmails.Where(a => a.Id == institutionEmailId).FirstOrDefault();
            context.InstitutionEmails.Remove(k);
            await context.SaveChangesAsync();
            return 1;
        }


        // Getting Institution Email based on InstitutionEmailId
        public async Task<InstitutionEmail> GetInstitutionEmailIdByinstitutionEmailId(int institutionEmailId)
        {
            var k = await context.InstitutionEmails.Where(a => a.Id == institutionEmailId).FirstOrDefaultAsync();
            return k;
        }


        //Getting All Institution Emails
        public async Task<List<InstitutionEmail>> GetInstitutionEmails()
        {
            return await context.InstitutionEmails?.ToListAsync();
        }


        // Inserting Institution Email
        public async Task<int> AddInstitutionEmail(InstitutionEmail institutionEmail)
        {
            context.InstitutionEmails.Add(institutionEmail);
            await context.SaveChangesAsync();
            return institutionEmail.Id;
        }


        // Updating Institution Email
        public async Task<int> UpdateInstitutionEmail(InstitutionEmail institutionEmail)
        {
            context.InstitutionEmails.Update(institutionEmail);
            await context.SaveChangesAsync();
            return institutionEmail.Id;
        }


        // Adding more than One Institution Email Details 
        public async Task<bool> AddRangeInstitutionEmails(List<InstitutionEmail> institutionEmails)
        {
            try
            {
                if (institutionEmails != null)
                {
                    context.InstitutionEmails.AddRange(institutionEmails);
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


        //Updating more than One Institution Emails
        public async Task<bool> UpdateRangeInstitutionEmails(List<InstitutionEmail> institutionEmails)
        {
            try
            {
                if (institutionEmails != null)
                {
                    context.InstitutionEmails.UpdateRange(institutionEmails);
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



        // Deleting more than One Institution Email Details
        public async Task<bool> DeleteRangeInstitutionEmails(List<InstitutionEmail> institutionEmails)
        {
            try
            {
                if (institutionEmails != null)
                {
                    context.InstitutionEmails.RemoveRange(institutionEmails);
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


        // Getting Institution Emails based on AddressId
        public async Task<List<InstitutionEmail>> GetInstitutionEmailsByAddressId(int addressId)
        {
            return await context.InstitutionEmails.Where(i => i.InstitutionAddressId == addressId).ToListAsync();
        }


    }
}
