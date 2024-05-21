using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class QulificationType
    {
        public QulificationType()
        {
            FamilyEducationDetails = new HashSet<FamilyEducationDetail>();
            Institutions = new HashSet<Institution>();
            Referrals = new HashSet<Referral>();
            UserEducationDetails = new HashSet<UserEducationDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<FamilyEducationDetail> FamilyEducationDetails { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
        public virtual ICollection<Referral> Referrals { get; set; }
        public virtual ICollection<UserEducationDetail> UserEducationDetails { get; set; }
    }
}
