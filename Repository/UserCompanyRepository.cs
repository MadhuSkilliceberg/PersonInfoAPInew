using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class UserCompanyRepository : IUserCompanyRepo
    {
        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();

        public async Task<int> AddUserCompanies(List<UserCompany> userCompanies)
        {
            try
            {
                if (userCompanies != null)
                {
                    context.UserCompanies.AddRange(userCompanies);
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

        public async Task<int> DeleteUserCompanyById(int id)
        {          
            context.UserCompanies.Remove(context.UserCompanies.Where(a => a.Id == id).FirstOrDefault());
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> DeleteUserCompaniesById(List<int> ids)
        {
            try
            {
                context.UserCompanies.RemoveRange(context.UserCompanies.Where(a => ids.Contains(a.Id)));
                await context.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<UserCompany> GetUserCompanyById(int id)
        {
            return await context.UserCompanies.Where(a => a.Id == id).FirstOrDefaultAsync();

        }

        public async Task<List<UserCompany>> GetUserCompanies()
        {
            return await context.UserCompanies.ToListAsync();
        }

        public async Task<List<UserCompany>> GetUserCompaniesByUserId(int UserId)
        {
            return await context.UserCompanies.Where(a => a.UserId == UserId).ToListAsync();
        }


        public async Task<int> AddUserCompany(UserCompany userCompany)
        {
            await context.UserCompanies.AddAsync(userCompany);
            await context.SaveChangesAsync();
            return userCompany.Id;
        }

   

        public async Task<int> UpdateUserCompany(UserCompany userCompany)
        {
            context.UserCompanies.Update(userCompany);
            await context.SaveChangesAsync();
            return userCompany.Id;
        }

        public async Task<int> UpdateUserCompanies(List<UserCompany> userCompanies)
        {
            try
            {
                context.UserCompanies.UpdateRange(userCompanies);
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
