using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class VacanciesSkill
    {
        public int Id { get; set; }
        public int? VacancyId { get; set; }
        public int? SkillId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Skill Skill { get; set; }
        public virtual Vacancy Vacancy { get; set; }
    }
}
