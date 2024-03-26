using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserProfileQuestion
    {
        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public int UserProfileId { get; set; }
        public int QuestionId { get; set; }
        public string OptionText { get; set; }
        public bool? Visited { get; set; }
        public bool? NotAnswered { get; set; }
        public bool? MarkForReview { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ModifiedBy { get; set; }
        public int? ExaminationId { get; set; }
        public string ProgramResponse { get; set; }
        public bool? IsAnswerCorrect { get; set; }
        public bool? IsExecuted { get; set; }
    }
}
