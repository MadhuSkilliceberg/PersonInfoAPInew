using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class SprintTask
    {
        public int Id { get; set; }
        public int? SprintId { get; set; }
        public int? TaskId { get; set; }
        public int? StatusId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Sprint Sprint { get; set; }
        public virtual Status Status { get; set; }
        public virtual Task Task { get; set; }
    }
}
