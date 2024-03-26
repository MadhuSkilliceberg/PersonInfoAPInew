using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class QuestionType
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string QuestionType1 { get; set; }
        public int OptionCount { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
