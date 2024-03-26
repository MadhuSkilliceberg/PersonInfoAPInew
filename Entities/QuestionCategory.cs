using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class QuestionCategory
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string QuestionCategory1 { get; set; }
        public int CutoffWeightage { get; set; }
        public int MinWeightage { get; set; }
        public int MaxWeightage { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifieDt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
