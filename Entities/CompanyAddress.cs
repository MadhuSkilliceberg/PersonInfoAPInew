using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class CompanyAddress
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string FlotNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? AddressTypeId { get; set; }
        public bool? Remote { get; set; }

        public virtual Company Company { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
    }
}
