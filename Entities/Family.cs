using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Family
    {
        public Family()
        {
            FamilyContacts = new HashSet<FamilyContact>();
            FamilyEducationDetails = new HashSet<FamilyEducationDetail>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? RelationTypeId { get; set; }
        public bool? IsGurdian { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual RelationType RelationType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<FamilyContact> FamilyContacts { get; set; }
        public virtual ICollection<FamilyEducationDetail> FamilyEducationDetails { get; set; }
    }
}
