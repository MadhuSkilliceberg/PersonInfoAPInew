using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Document
    {
        public Document()
        {
            CommentDocuments = new HashSet<CommentDocument>();
        }

        public int Id { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string File { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<CommentDocument> CommentDocuments { get; set; }
    }
}
