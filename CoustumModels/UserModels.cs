using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.CoustumModels
{
    public class UserModels
    {
        public User user { get; set; }
        public UserAddressDetail userAddressDetails { get; set; }
        public UserCompany userCompany { get; set; }
        public UserContact userContact { get; set; }
        public UserCourse userCourses { get; set; }
        public UserEducationDetail userEducationDetails { get; set; }
        public UserEmail userEmails { get; set; }
        public UserSkill userSkills { get; set; }
        public UserType userTypes { get; set; }
    }


    public class UserDetail {
        public User user { get; set; }
        public List<UserAddressDetail> userAddressDetails { get; set; }
        public List<UserCompany> userCompanies { get; set; }
        public List<UserContact> userContacts { get; set; }
        public List<UserCourse> userCourses { get; set; }
        public List<UserEducationDetail> userEducationDetails { get; set; }
        public List<UserEmail> userEmails { get; set; }
        public List<UserSkill> userSkills { get; set; }
    }

}


