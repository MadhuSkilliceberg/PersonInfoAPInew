using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class ExaminationSession
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int ExaminationId { get; set; }
        public DateTime SessionTime { get; set; }
        public string SessionJson { get; set; }
        public double RemainingTime { get; set; }
        public bool? IsExamActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifieDt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
