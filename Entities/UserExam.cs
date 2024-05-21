using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserExam
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int? ExamId { get; set; }
        public int? UserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Updatedon { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime StartOn { get; set; }
        public DateTime CloseOn { get; set; }
    }
}
