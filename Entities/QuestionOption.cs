using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class QuestionOption
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public int? StatusId { get; set; }
        public string Option { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Question Question { get; set; }
        public virtual Status Status { get; set; }
    }
}
