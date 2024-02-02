using PersonsInfoV2Api.Entities;
using System.Collections.Generic;
using System;

namespace PersonsInfoV2Api.Models
{
    public class UserModel
    {

        public User User { get; set; }
        public List<UserAddressDetail> UserAddressDetails { get; set; }
        public List<UserCompany> UserCompanies { get; set; }
        public List<UserContact> UserContacts { get; set; }
        public List<UserCourse> UserCourses { get; set; }
        public List<UserEducationDetail> UserEducationDetails { get; set; }
        public List<UserEmail> UserEmails { get; set; }
        public List<UserSkill> UserSkills { get; set; }

    }
}
