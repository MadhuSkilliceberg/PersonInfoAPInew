using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;

namespace PersonsInfoV2Api.Models
{
    public class UserExamQuestionModel
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ExamId { get; set; }
        public int? QuestionId { get; set; }
        public string QuestionName { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? MarkAsReview { get; set; }
        public string Answer { get; set; }

        public  List<QuestionOption> QuestionOption { get; set; }
       
    }
}
