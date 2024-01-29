using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Company
    {
        public Company()
        {
            CompanyAddresses = new HashSet<CompanyAddress>();
            CompanyBenefits = new HashSet<CompanyBenefit>();
            CompanyJobTypes = new HashSet<CompanyJobType>();
            CompanyJobs = new HashSet<CompanyJob>();
            CompanyReviews = new HashSet<CompanyReview>();
            UserCompanies = new HashSet<UserCompany>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }
        public virtual ICollection<CompanyBenefit> CompanyBenefits { get; set; }
        public virtual ICollection<CompanyJobType> CompanyJobTypes { get; set; }
        public virtual ICollection<CompanyJob> CompanyJobs { get; set; }
        public virtual ICollection<CompanyReview> CompanyReviews { get; set; }
        public virtual ICollection<UserCompany> UserCompanies { get; set; }
    }
}
