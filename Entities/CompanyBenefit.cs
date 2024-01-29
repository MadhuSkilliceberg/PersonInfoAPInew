using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class CompanyBenefit
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BenefitId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual LookUpValue Benefit { get; set; }
        public virtual Company Company { get; set; }
    }
}
