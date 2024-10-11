using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class AdattendanceApproval
    {
        public int AttendanceApprovalId { get; set; }
        public int? AttendanceId { get; set; }
        public int? UserId { get; set; }
        public int? UserParentId { get; set; }
        public int? Level { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? Status { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual LookUpValue StatusNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
