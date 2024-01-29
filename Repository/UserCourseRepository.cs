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
        PersonsInfoV3NewContext person = new PersonsInfoV3NewContext();

        public bool AddUserCoures(List<UserCourse> userCourses)
        {
            try
            {
                if (userCourses != null)
                {
                    person.UserCourses.AddRange(userCourses);
                    person.SaveChanges();
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
            var a = person.UserCourses.Where(c => c.Id == id).FirstOrDefault();
            person.UserCourses.Remove(a);
            person.SaveChanges();
            return 1;
        }

        public UserCourse GetByUserCourseId(int id)
        {
            return person.UserCourses.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<UserCourse> GetUserCourse()
        {
            return person.UserCourses.ToList();
        }

        public int InsertUserCourse(UserCourse userCourse)
        {
            try
            {
                person.UserCourses.Add(userCourse);
                person.SaveChanges();
                return userCourse.Id;
            }catch(Exception ex)
            {
                return 0;
            }

        }

        public int UpdateUserCourse(UserCourse userCourse)
        {
            person.UserCourses.Update(userCourse);
            person.SaveChanges();
            return userCourse.Id;
        }
    }
}
