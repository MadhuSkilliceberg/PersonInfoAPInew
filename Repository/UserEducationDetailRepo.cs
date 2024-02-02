using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class UserEducationDetailRepo: IUserEducationDetailRepo
    {
        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();

        public async Task<int> DeleteUserEducationDetail(int id)
        {
            context.UserEducationDetails.Remove(context.UserEducationDetails.Where(a => a.Id == id).FirstOrDefault());
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> DeleteRangeUserEducationDetail(List<int> ids)
        {         
            context.UserEducationDetails.RemoveRange(await context.UserEducationDetails.Where(a => ids.Contains(a.Id)).ToListAsync());
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<UserEducationDetail> GetUserEducationDetailsById(int id)
        {
           return context.UserEducationDetails.Where(a => a.Id == id).FirstOrDefault();
           
        }

        public async Task<List<UserEducationDetail>> GetUserEducationDetailsByUserId(int userId)
        {
            return await context.UserEducationDetails.Where(a => a.Id == userId).ToListAsync();
        }

        

        public async Task<List<UserEducationDetail>> GetUserEducationDetails()
        {
            return await context.UserEducationDetails.ToListAsync(); 
        }

        public async Task<int> InsertUserEducationDetail(UserEducationDetail userEducationDetail)
        {
            await context.UserEducationDetails.AddAsync(userEducationDetail);
            await context.SaveChangesAsync();
            return userEducationDetail.Id;
        }


        public async  Task<int> InsertUserEducationDetails(List<UserEducationDetail> userEducationDetail)
        {
           
            try
            {
                await context.UserEducationDetails.AddRangeAsync(userEducationDetail);
                await context.SaveChangesAsync();
                return 1;
            }
            catch
            {

            }
            return 0;
        }

        public async Task<int> UpdateUserEducationDetail(UserEducationDetail userEducationDetail)
        {
            context.UserEducationDetails.Update(userEducationDetail);
            await context.SaveChangesAsync();
            return userEducationDetail.Id;
        }

        public async Task<int> UpdateUserEducationDetails(List<UserEducationDetail> userEducationDetails)
        {
            try
            {
                context.UserEducationDetails.UpdateRange(userEducationDetails);
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
