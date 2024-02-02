using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class UserContactRepo : IUserContactRepo
    {

        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();
        public async Task<int> AddUserContacts(List<UserContact> userContacts)
        {
            try
            {
                if (userContacts != null)
                {
                    context.UserContacts.AddRange(userContacts);
                    await context.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<int> DeleteUserContactById(int id)
        {
            context.UserContacts.Remove(context.UserContacts.Where(a => a.Id == id).FirstOrDefault());
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> DeleteUserContact(List<int> ids)
        {
            try
            {
                context.UserContacts.RemoveRange(context.UserContacts.Where(a => ids.Contains(a.Id)));
                await context.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<UserContact> GetUserContactById(int id)
        {
            return await context.UserContacts.Where(a => a.Id == id).FirstOrDefaultAsync();

        }

        public async Task<List<UserContact>> GetUserContacts()
        {
            return await context.UserContacts.ToListAsync();
        }

        public async Task<List<UserContact>> GetUserContactsByUserId(int UserId)
        {
            return await context.UserContacts.Where(a => a.UserId == UserId).ToListAsync();
        }

        public async Task<int> AddUserContact(UserContact userContact)
        {
            await context.UserContacts.AddAsync(userContact);
            await context.SaveChangesAsync();
            return userContact.Id;
        }



        public async Task<int> UpdateUserContact(UserContact userContact)
        {
            context.UserContacts.Update(userContact);
            await context.SaveChangesAsync();
            return userContact.Id;
        }

        public async Task<int> UpdateUserContacts(List<UserContact> userContacts)
        {
            try
            {
                context.UserContacts.UpdateRange(userContacts);
                await context.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }


    }
}
