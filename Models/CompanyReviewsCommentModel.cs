using PersonsInfoV2Api.Entities;
using System.Collections.Generic;
using System;

namespace PersonsInfoV2Api.Models
{
    public class CompanyReviewsCommentModel
    {
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

        public ICollection<CommentDocument> CommentDocuments { get; set; }

    }
}
