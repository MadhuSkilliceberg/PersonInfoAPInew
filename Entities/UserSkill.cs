using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserSkill
    {
        public int Id { get; set; }
        public int? SkillId { get; set; }
        public bool? IsPrimary { get; set; }
        public int? UserId { get; set; }
        public int? OrderId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Skill Skill { get; set; }
        public virtual User User { get; set; }
    }
}
