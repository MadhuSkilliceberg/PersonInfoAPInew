using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class ContactType
    {
        public ContactType()
        {
            CompanyContacts = new HashSet<CompanyContact>();
            CompanyEmails = new HashSet<CompanyEmail>();
            UserContacts = new HashSet<UserContact>();
            UserEmails = new HashSet<UserEmail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<CompanyContact> CompanyContacts { get; set; }
        public virtual ICollection<CompanyEmail> CompanyEmails { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
        public virtual ICollection<UserEmail> UserEmails { get; set; }
    }
}
