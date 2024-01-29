using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class TaskState
    {
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public int? Assigned { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual User AssignedNavigation { get; set; }
        public virtual Task Task { get; set; }
    }
}
