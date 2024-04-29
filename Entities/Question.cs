using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Question
    {
        public Question()
        {
            QuestionOptions = new HashSet<QuestionOption>();
            UserExamQuestions = new HashSet<UserExamQuestion>();
        }

        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int SkillId { get; set; }
        public int? QuestionTypeId { get; set; }
        public int? QuestionCategoryId { get; set; }
        public string Question1 { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
        public string CorrectAnswer { get; set; }
        public int? Weightage { get; set; }
        public bool? IsPublish { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ModifiedBy { get; set; }
        public bool? ShowEditor { get; set; }

        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
        public virtual ICollection<UserExamQuestion> UserExamQuestions { get; set; }
    }
}
