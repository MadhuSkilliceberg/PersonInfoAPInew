
using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class UserEmailRepo : IUserEmailRepo
    {

        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();

        public async Task<int> AddUserEmails(List<UserEmail> userEmails)
        {
            try
            {
                if (userEmails != null)
                {
                    context.UserEmails.AddRange(userEmails);
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

        public async Task<int> DeleteUserEmails(int id)
        {
            var k = context.UserEmails.Where(a => a.Id == id).FirstOrDefault();
            context.UserEmails.Remove(k);
            await context.SaveChangesAsync();
            return 1;
        }



        public async Task<UserEmail> GetUserEmailById(int id)
        {
            return await context.UserEmails.Where(a => a.Id == id).FirstOrDefaultAsync();
          
        }

        public async Task<List<UserEmail>> GetUserEmailByUserId(int userId)
        {
            return await context.UserEmails.Where(a => a.Id == userId).ToListAsync();
        }


        public Task<List<UserEmail>> GetUserEmails()
        {
            return context.UserEmails.ToListAsync();
        }

        public async Task<List<UserEmail>> GetUserEmailsByUserId(int UserId)
        {
            return await context.UserEmails.Where(a => a.UserId == UserId).ToListAsync();
        }

        public async Task<int> AddUserEmail(UserEmail user)
        {
            await context.UserEmails.AddAsync(user);
            await context.SaveChangesAsync();
            return 1;
        }

        
        public async Task<int> UpdateUserEmail(UserEmail user)
        {
            context.UserEmails.Update(user);
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> UpdateUserEmails(List<UserEmail> userEmails)
        {
            context.UserEmails.UpdateRange(userEmails);
            await context.SaveChangesAsync();
            return 1;
        }

       
    }
}
