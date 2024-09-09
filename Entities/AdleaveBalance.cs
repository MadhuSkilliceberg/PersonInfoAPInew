using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class AdleaveBalance
    {
        public int LeaveBalanceId { get; set; }
        public int? UserId { get; set; }
        public int? LeaveTypeId { get; set; }
        public decimal? AdleaveBalance1 { get; set; }
        public DateTime? LastUpdated { get; set; }

        public virtual AdleaveType LeaveType { get; set; }
        public virtual User User { get; set; }
    }
}
