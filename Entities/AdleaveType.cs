using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class AdleaveType
    {
        public AdleaveType()
        {
            AdleaveBalances = new HashSet<AdleaveBalance>();
            AdleaveRequests = new HashSet<AdleaveRequest>();
        }

        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; }
        public int? LeaveDaysPerYear { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<AdleaveBalance> AdleaveBalances { get; set; }
        public virtual ICollection<AdleaveRequest> AdleaveRequests { get; set; }
    }
}
