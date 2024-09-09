using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserExamQuestion
    {
        public UserExamQuestion()
        {
            UserExamQuestionsAudits = new HashSet<UserExamQuestionsAudit>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ExamId { get; set; }
        public int? QuestionId { get; set; }
        public int? MarkAsReview { get; set; }
        public string Answer { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Question Question { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserExamQuestionsAudit> UserExamQuestionsAudits { get; set; }
    }
}
