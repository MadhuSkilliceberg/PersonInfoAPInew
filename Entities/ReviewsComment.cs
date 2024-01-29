using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class ReviewsComment
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Review Review { get; set; }
        public virtual User User { get; set; }
    }
}
