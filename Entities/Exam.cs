using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Exam
    {
        public Exam()
        {
            ExamQuestions = new HashSet<ExamQuestion>();
            UserExamQuestions = new HashSet<UserExamQuestion>();
            UserExams = new HashSet<UserExam>();
        }

        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int SkillId { get; set; }
        public int? ExamTypeId { get; set; }
        public int? ExamCategoryId { get; set; }
        public bool? IsPublish { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updatedon { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime StartOn { get; set; }
        public DateTime CloseOn { get; set; }

        public virtual ICollection<ExamQuestion> ExamQuestions { get; set; }
        public virtual ICollection<UserExamQuestion> UserExamQuestions { get; set; }
        public virtual ICollection<UserExam> UserExams { get; set; }
    }
}
