using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class VerificationCenterExamination
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int VerificationId { get; set; }
        public int UserProfileId { get; set; }
        public DateTime ExaminationDate { get; set; }
        public bool? IsAssessmentComplete { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifieDt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
