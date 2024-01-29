using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class FamilyEducationDetail
    {
        public int Id { get; set; }
        public int? FamilyId { get; set; }
        public int? QulificationtypeId { get; set; }
        public int? YearOfpassout { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? InstitutionId { get; set; }
        public int? Percentage { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Family Family { get; set; }
        public virtual InstitutionAddress Institution { get; set; }
        public virtual QulificationType Qulificationtype { get; set; }
    }
}
