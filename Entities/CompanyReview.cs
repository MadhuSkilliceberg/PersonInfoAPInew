using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class CompanyReview
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ReviewId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual Review Review { get; set; }
    }
}
