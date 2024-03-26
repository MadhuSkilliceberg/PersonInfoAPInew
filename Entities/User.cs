using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class User
    {
        public User()
        {
            Chats = new HashSet<Chat>();
            Events = new HashSet<Event>();
            Families = new HashSet<Family>();
            News = new HashSet<News>();
            ReviewsComments = new HashSet<ReviewsComment>();
            TaskStates = new HashSet<TaskState>();
            UserAddressDetails = new HashSet<UserAddressDetail>();
            UserCompanies = new HashSet<UserCompany>();
            UserContacts = new HashSet<UserContact>();
            UserCourses = new HashSet<UserCourse>();
            UserEducationDetails = new HashSet<UserEducationDetail>();
            UserEmails = new HashSet<UserEmail>();
            UserExamQuestions = new HashSet<UserExamQuestion>();
            UserExamQuestionsAudits = new HashSet<UserExamQuestionsAudit>();
            UserExams = new HashSet<UserExam>();
            UserSkills = new HashSet<UserSkill>();
            VacancyCreatedByNavigations = new HashSet<Vacancy>();
            VacancyUpdatedByNavigations = new HashSet<Vacancy>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public int? GenderId { get; set; }
        public int? MarritalStatusId { get; set; }
        public long? MobileNumber { get; set; }
        public long? AadharNumber { get; set; }
        public string VoterId { get; set; }
        public string PanCardNumber { get; set; }
        public int? UserTypeId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string RefferalCode { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual MarritalStatus MarritalStatus { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Family> Families { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<ReviewsComment> ReviewsComments { get; set; }
        public virtual ICollection<TaskState> TaskStates { get; set; }
        public virtual ICollection<UserAddressDetail> UserAddressDetails { get; set; }
        public virtual ICollection<UserCompany> UserCompanies { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
        public virtual ICollection<UserEducationDetail> UserEducationDetails { get; set; }
        public virtual ICollection<UserEmail> UserEmails { get; set; }
        public virtual ICollection<UserExamQuestion> UserExamQuestions { get; set; }
        public virtual ICollection<UserExamQuestionsAudit> UserExamQuestionsAudits { get; set; }
        public virtual ICollection<UserExam> UserExams { get; set; }
        public virtual ICollection<UserSkill> UserSkills { get; set; }
        public virtual ICollection<Vacancy> VacancyCreatedByNavigations { get; set; }
        public virtual ICollection<Vacancy> VacancyUpdatedByNavigations { get; set; }
    }
}
