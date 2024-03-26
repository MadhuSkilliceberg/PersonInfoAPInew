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
            InstitutionEducationProgramTypes = new HashSet<InstitutionEducationProgramType>();
            InstitutionMedia = new HashSet<InstitutionMedium>();
            JobJobTypes = new HashSet<JobJobType>();
            JobSchedules = new HashSet<JobSchedule>();
            JobSupplementalPays = new HashSet<JobSupplementalPay>();
            UserAddressDetails = new HashSet<UserAddressDetail>();
            UserExamQuestionsAudits = new HashSet<UserExamQuestionsAudit>();
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
        public virtual ICollection<InstitutionEducationProgramType> InstitutionEducationProgramTypes { get; set; }
        public virtual ICollection<InstitutionMedium> InstitutionMedia { get; set; }
        public virtual ICollection<JobJobType> JobJobTypes { get; set; }
        public virtual ICollection<JobSchedule> JobSchedules { get; set; }
        public virtual ICollection<JobSupplementalPay> JobSupplementalPays { get; set; }
        public virtual ICollection<UserAddressDetail> UserAddressDetails { get; set; }
        public virtual ICollection<UserExamQuestionsAudit> UserExamQuestionsAudits { get; set; }
    }
}
