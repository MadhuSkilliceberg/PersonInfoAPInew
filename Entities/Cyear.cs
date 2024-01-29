using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Cyear
    {
        public Cyear()
        {
            CourseYears = new HashSet<CourseYear>();
            YearSemesters = new HashSet<YearSemester>();
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
        public virtual ICollection<YearSemester> YearSemesters { get; set; }
    }
}
