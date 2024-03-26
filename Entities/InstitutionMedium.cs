using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class InstitutionMedium
    {
        public int Id { get; set; }
        public int InstitutionId { get; set; }
        public int LookUpId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Institution Institution { get; set; }
        public virtual LookUpValue LookUp { get; set; }
    }
}
