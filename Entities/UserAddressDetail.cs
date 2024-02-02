using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserAddressDetail
    {
        public int Id { get; set; }
        public string FlotNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? UserId { get; set; }
        public bool? IsPermanent { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? TypeId { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual LookUpValue Type { get; set; }
        public virtual User User { get; set; }
    }
}
