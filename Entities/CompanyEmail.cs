using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class CompanyEmail
    {
        public int Id { get; set; }
        public int? CompanyAddressId { get; set; }
        public string Email { get; set; }
        public bool? IsPrimary { get; set; }
        public int? OrderId { get; set; }
        public int? ContactTypeId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}
