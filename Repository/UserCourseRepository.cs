using Microsoft.EntityFrameworkCore;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.Repository
{
    public class UserCourseRepository : IRepoUserCourse
    {
        PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();

        public bool AddUserCoures(List<UserCourse> userCourses)
        {
            try
            {
                if (userCourses != null)
                {
                    context.UserCourses.AddRange(userCourses);
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

        public int DeleteUserCourse(int id)
        {
            var a = context.UserCourses.Where(c => c.Id == id).FirstOrDefault();
            context.UserCourses.Remove(a);
            context.SaveChanges();
            return 1;
        }

        public UserCourse GetByUserCourseId(int id)
        {
            return context.UserCourses.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<UserCourse> GetUserCourse()
        {
            return context.UserCourses.ToList();
        }

        public async Task<List<UserCourse>> GetUserCoursesByUserId(int UserId)
        {
            return await context.UserCourses.Where(a => a.UserId == UserId).ToListAsync();
        }

        public int InsertUserCourse(UserCourse userCourse)
        {
            try
            {
                context.UserCourses.Add(userCourse);
                context.SaveChanges();
                return userCourse.Id;
            }catch(Exception ex)
            {
                return 0;
            }

        }

        public int UpdateUserCourse(UserCourse userCourse)
        {
            context.UserCourses.Update(userCourse);
            context.SaveChanges();
            return userCourse.Id;
        }

        public int UpdateUserCourses(List<UserCourse> userCourses)
        {
            context.UserCourses.UpdateRange(userCourses);
            context.SaveChanges();
            return 1;
        }
    }
}
