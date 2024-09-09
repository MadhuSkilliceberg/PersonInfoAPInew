using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class AdleaveRequest
    {
        public int LeaveRequestId { get; set; }
        public int? UserId { get; set; }
        public int? LeaveTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime? AppliedDate { get; set; }
        public int? ReviewedBy { get; set; }
        public DateTime? ReviewedDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual AdleaveType LeaveType { get; set; }
        public virtual User User { get; set; }
    }
}
