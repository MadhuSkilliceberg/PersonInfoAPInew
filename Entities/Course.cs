using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Course
    {
        public Course()
        {
            CourseYears = new HashSet<CourseYear>();
            InstitutionCourses = new HashSet<InstitutionCourse>();
            UserCourses = new HashSet<UserCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Code { get; set; }
        public int? OrderId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<CourseYear> CourseYears { get; set; }
        public virtual ICollection<InstitutionCourse> InstitutionCourses { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
