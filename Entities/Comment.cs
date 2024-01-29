using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Comment
    {
        public Comment()
        {
            CommentDocuments = new HashSet<CommentDocument>();
            ReviewsComments = new HashSet<ReviewsComment>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPublic { get; set; }
        public int? AccessLevel { get; set; }
        public int? ParentId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<CommentDocument> CommentDocuments { get; set; }
        public virtual ICollection<ReviewsComment> ReviewsComments { get; set; }
    }
}
