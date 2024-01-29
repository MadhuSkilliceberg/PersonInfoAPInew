using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class CompanyJobType
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int JobTypeId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual LookUpValue JobType { get; set; }
    }
}
