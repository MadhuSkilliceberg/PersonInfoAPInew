using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Job
    {
        public Job()
        {
            CompanyJobs = new HashSet<CompanyJob>();
            InstitutionJobs = new HashSet<InstitutionJob>();
            JobJobTypes = new HashSet<JobJobType>();
            JobSchedules = new HashSet<JobSchedule>();
            JobSupplementalPays = new HashSet<JobSupplementalPay>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? LocationId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? ScheduleShiftId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? NumberofHiring { get; set; }
        public decimal? Pay { get; set; }
        public bool? IsApplicationDeadLine { get; set; }
        public bool? RequireCv { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsWhatsAppUpdates { get; set; }
        public bool? DirectContact { get; set; }

        public virtual Department Department { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<CompanyJob> CompanyJobs { get; set; }
        public virtual ICollection<InstitutionJob> InstitutionJobs { get; set; }
        public virtual ICollection<JobJobType> JobJobTypes { get; set; }
        public virtual ICollection<JobSchedule> JobSchedules { get; set; }
        public virtual ICollection<JobSupplementalPay> JobSupplementalPays { get; set; }
    }
}
