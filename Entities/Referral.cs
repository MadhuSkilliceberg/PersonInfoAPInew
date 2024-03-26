using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Referral
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? MobileNumber { get; set; }
        public string Email { get; set; }
        public int? EducationQualificationId { get; set; }
        public int? StateId { get; set; }
        public string RefferalCode { get; set; }
        public bool? EnableWhatsUp { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual QulificationType EducationQualification { get; set; }
        public virtual State State { get; set; }
    }
}
