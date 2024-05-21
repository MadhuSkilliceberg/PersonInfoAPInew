using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class LookUpValue
    {
        public LookUpValue()
        {
            CompanyBenefits = new HashSet<CompanyBenefit>();
            CompanyJobTypes = new HashSet<CompanyJobType>();
            JobJobTypes = new HashSet<JobJobType>();
            JobSchedules = new HashSet<JobSchedule>();
            JobSupplementalPays = new HashSet<JobSupplementalPay>();
            UserAddressDetails = new HashSet<UserAddressDetail>();
        }

        public int Id { get; set; }
        public int LookUpId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? ParentId { get; set; }

        public virtual ICollection<CompanyBenefit> CompanyBenefits { get; set; }
        public virtual ICollection<CompanyJobType> CompanyJobTypes { get; set; }
        public virtual ICollection<JobJobType> JobJobTypes { get; set; }
        public virtual ICollection<JobSchedule> JobSchedules { get; set; }
        public virtual ICollection<JobSupplementalPay> JobSupplementalPays { get; set; }
        public virtual ICollection<UserAddressDetail> UserAddressDetails { get; set; }
    }
}
