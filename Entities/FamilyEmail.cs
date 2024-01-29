using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class FamilyEmail
    {
        public int Id { get; set; }
        public int? InstitutionAddressId { get; set; }
        public long? Email { get; set; }
        public bool? IsPrimary { get; set; }
        public int? OrderId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual InstitutionAddress InstitutionAddress { get; set; }
    }
}
