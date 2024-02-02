using PersonsInfoV2Api.IRepository;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonsInfoV2Api.Repository
{
    public class UserSkillRepository : IUserSkillRepo
    {
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();

        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();
        public async Task<int> AddUserSkills(List<UserSkill> userSkills)
        {
            try
            {
                if (userSkills != null)
                {
                    context.UserSkills.AddRange(userSkills);
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

        public async Task<int> DeleteUserSkillById(int id)
        {
            context.UserSkills.Remove(context.UserSkills.Where(a => a.Id == id).FirstOrDefault());
            await context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> DeleteUserSkill(List<int> ids)
        {
            try
            {
                context.UserSkills.RemoveRange(context.UserSkills.Where(a => ids.Contains(a.Id)));
                await context.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<UserSkill> GetUserSkillById(int id)
        {
            return await context.UserSkills.Where(a => a.Id == id).FirstOrDefaultAsync();

        }

        public async Task<List<UserSkill>> GetUserSkills()
        {
            return await context.UserSkills.ToListAsync();
        }

        public async Task<List<UserSkill>> GetUserSkillsByUserId(int UserId)
        {
            return await context.UserSkills.Where(a => a.UserId == UserId).ToListAsync();
        }

        public async Task<int> AddUserSkill(UserSkill userSkill)
        {
            await context.UserSkills.AddAsync(userSkill);
            await context.SaveChangesAsync();
            return userSkill.Id;
        }



        public async Task<int> UpdateUserSkill(UserSkill userSkill)
        {
            context.UserSkills.Update(userSkill);
            await context.SaveChangesAsync();
            return userSkill.Id;
        }

        public async Task<int> UpdateUserSkills(List<UserSkill> userSkills)
        {
            try
            {
                context.UserSkills.UpdateRange(userSkills);
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
