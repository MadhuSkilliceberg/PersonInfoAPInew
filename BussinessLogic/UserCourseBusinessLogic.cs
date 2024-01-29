using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using PersonsInfoV2Api.IBussinessLogic;
using PersonsInfoV2Api.IRepository;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class UserCourseBusinessLogic : IUserCourseBusinessLogic
    {
        IRepoUserCourse userCourse;
        ICourseRepo courseRepo;
        IUserRepository userRepository;

        public UserCourseBusinessLogic(IRepoUserCourse Repo, ICourseRepo courseRepo, IUserRepository userRepository)
        {
            userCourse = Repo;
            this.courseRepo = courseRepo;
            this.userRepository = userRepository;
        }

        public int DeleteUserCourse(int id)
        {
            return userCourse.DeleteUserCourse(id);
        }

         public UserCourse GetByUserCourseId(int id)
        {
            return userCourse.GetByUserCourseId(id);
        }

        public List<UserCourse> GetUserCourse()
        {
            return userCourse.GetUserCourse();
        }

        public int InsertUserCourse(UserCourse userCourses)
        {
            return userCourse.InsertUserCourse(userCourses);
        }

        public int UpdateUserCourse(UserCourse userCourses)
        {
            return userCourse.UpdateUserCourse(userCourses);
        }

        public List<UserCourseList> GetUserCourseList()
        {
            var userCourseList = userCourse.GetUserCourse();
            var courseRepoList = courseRepo.GetCourse();
            var userRepoList = userRepository.GetUsers();

            var data = from U in userCourseList
                       join
                       CRL in courseRepoList
                       on U.CourseId equals CRL.Id
                       join
                       URL in userRepoList
                       on U.UserId equals URL.Id


                       select new UserCourseList
                       {
                           Id = U.Id,
                           Name = CRL.Name,
                           IsPrimary = U.IsPrimary,
                           FirstName = URL.FirstName,
                           OrderId = U.OrderId
                       };
            return data.ToList();
        }
    }
}
