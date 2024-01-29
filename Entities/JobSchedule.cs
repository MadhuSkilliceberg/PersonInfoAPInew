using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class JobSchedule
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int ScheduleId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Job Job { get; set; }
        public virtual LookUpValue Schedule { get; set; }
    }
}
