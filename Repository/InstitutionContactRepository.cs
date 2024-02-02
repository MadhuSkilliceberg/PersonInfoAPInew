using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class InstitutionContactRepository : IInstitutionContactRepository
    {
       private PersonsInfoV3NewContext context;


        public InstitutionContactRepository(PersonsInfoV3NewContext context)
        {
            this.context = context;
        }

        // Deleting InstitutionContact based on InstitutionContactId
        public async Task<int> DeleteInstitutionContactByInstitutionContactId(int institutionContactId)
        {
            var k = context.InstitutionContacts.Where(a => a.Id == institutionContactId).FirstOrDefault();
            context.InstitutionContacts.Remove(k);
          await  context.SaveChangesAsync();
            return 1;
        }



        // Getting Institution Contact based on Id
        public async Task<InstitutionContact> GetInstitutionContactByInstitutionContactId(int institutionContactId)
        {
            return await context.InstitutionContacts.Where(a => a.Id == institutionContactId).FirstOrDefaultAsync();

        }


        // Getting All Institution Contacts List
        public async Task<List<InstitutionContact>> GetInstitutionContacts()
        {
            return await context.InstitutionContacts.ToListAsync();
        }



        //Inserting Institution Contact into Institution Contacts
        public async Task<int> AddInstitutionContact(InstitutionContact institutionContact)
        {
            context.InstitutionContacts.Add(institutionContact);
          await  context.SaveChangesAsync();
            return institutionContact.Id;
        }



        // Updating Institution Contact 
        public async Task<int> UpdateInstitutionContact(InstitutionContact institutionContact)
        {
            context.InstitutionContacts.Update(institutionContact);
          await  context.SaveChangesAsync();
            return institutionContact.Id;
        }



        // Adding List of Contact Details
        public async Task<bool> AddRangeInstitutionContacts(List<InstitutionContact> institutionContacts)
        {
            try
            {
                if (institutionContacts != null)
                {
                  await  context.InstitutionContacts.AddRangeAsync(institutionContacts);
                    context.SaveChanges();
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



        // Updating more than One  Institution Contact Details
        public async Task<bool> UpdateRangeInstitutionContacts(List<InstitutionContact> institutionContacts)
        {
            try
            {
                if (institutionContacts != null)
                {
                    context.InstitutionContacts.UpdateRange(institutionContacts);
                 await   context.SaveChangesAsync();
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


        // Deleting more than One Institution Contact Details 
        public async Task<bool> DeleteRangeInstitutionContacts(List<InstitutionContact> institutionContacts)
        {
            try
            {
                if (institutionContacts != null)
                {
                    context.InstitutionContacts.RemoveRange(institutionContacts);
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



        //Getting Institution Contact  based on AddresseId
        public async Task<List<InstitutionContact>> GetInstitutionContactsByAddressId(int addressId)
        {
            return await context.InstitutionContacts.Where(i => i.InstitutionAddressId == addressId).ToListAsync();
        }
    }
}
