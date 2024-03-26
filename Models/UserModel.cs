using PersonsInfoV2Api.Entities;
using System.Collections.Generic;

namespace PersonsInfoV2Api.Models
{
    public class UserModel
    {
       public User User { get; set; }
        public  Gender Gender { get; set; }
        public  MarritalStatus MarritalStatus { get; set; }
        public  UserType UserType { get; set; }
        public  List<Chat> Chats { get; set; }
        public  List<Event> Events { get; set; }
        public  List<Family> Families { get; set; }
        public  List<News> News { get; set; }
        public  List<ReviewsComment> ReviewsComments { get; set; }
        public  List<TaskState> TaskStates { get; set; }
        public  List<UserAddressDetail> UserAddressDetails { get; set; }
        public  List<UserCompany> UserCompanies { get; set; }
        public  List<UserContact> UserContacts { get; set; }
        public  List<UserCourse> UserCourses { get; set; }
        public  List<UserEducationDetail> UserEducationDetails { get; set; }
        public  List<UserEmail> UserEmails { get; set; }
        public  List<UserSkill> UserSkills { get; set; }
        public  List<Vacancy> VacancyCreatedByNavigations { get; set; }
        public  List<Vacancy> VacancyUpdatedByNavigations { get; set; }
    }
}
