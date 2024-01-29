using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Institution
    {
        public Institution()
        {
            InstitutionAddressInstitutions = new HashSet<InstitutionAddress>();
            InstitutionAddressStates = new HashSet<InstitutionAddress>();
            InstitutionCourses = new HashSet<InstitutionCourse>();
            InstitutionJobs = new HashSet<InstitutionJob>();
            UserEducationDetails = new HashSet<UserEducationDetail>();
        }

        public int Id { get; set; }
        public string InstitutionName { get; set; }
        public int? QulificationTypeId { get; set; }
        public int? MediumId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Medium Medium { get; set; }
        public virtual QulificationType QulificationType { get; set; }
        public virtual ICollection<InstitutionAddress> InstitutionAddressInstitutions { get; set; }
        public virtual ICollection<InstitutionAddress> InstitutionAddressStates { get; set; }
        public virtual ICollection<InstitutionCourse> InstitutionCourses { get; set; }
        public virtual ICollection<InstitutionJob> InstitutionJobs { get; set; }
        public virtual ICollection<UserEducationDetail> UserEducationDetails { get; set; }
    }
}
