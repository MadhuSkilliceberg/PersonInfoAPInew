using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class EmploymentType
    {
        public EmploymentType()
        {
            VacancyEducationTypes = new HashSet<Vacancy>();
            VacancyEmploymentTypes = new HashSet<Vacancy>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<Vacancy> VacancyEducationTypes { get; set; }
        public virtual ICollection<Vacancy> VacancyEmploymentTypes { get; set; }
    }
}
