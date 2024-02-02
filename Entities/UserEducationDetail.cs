using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserEducationDetail
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? QulificationtypeId { get; set; }
        public int? YearOfpassout { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? InstitutionId { get; set; }
        public int? Percentage { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Institution Institution { get; set; }
        public virtual QulificationType Qulificationtype { get; set; }
        public virtual User User { get; set; }
    }
}
