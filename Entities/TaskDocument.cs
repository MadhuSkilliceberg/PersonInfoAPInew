using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class TaskDocument
    {
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string File { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Task Task { get; set; }
    }
}
