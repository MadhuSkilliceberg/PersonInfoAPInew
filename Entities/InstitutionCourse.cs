using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class InstitutionCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? InstitutionId { get; set; }
        public int? CourseId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Course Course { get; set; }
        public virtual Institution Institution { get; set; }
    }
}
