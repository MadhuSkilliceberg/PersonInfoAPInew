using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserExamQuestionsAudit
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? UserExamQuestionId { get; set; }
        public bool? IsActive { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual UserExamQuestion UserExamQuestion { get; set; }
    }
}
