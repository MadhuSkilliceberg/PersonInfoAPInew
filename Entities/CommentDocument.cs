using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class CommentDocument
    {
        public int Id { get; set; }
        public int? CommentId { get; set; }
        public int? DocumentId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Document Document { get; set; }
    }
}
