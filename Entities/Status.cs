using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Status
    {
        public Status()
        {
            QuestionOptions = new HashSet<QuestionOption>();
            SprintTasks = new HashSet<SprintTask>();
            Vacancies = new HashSet<Vacancy>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
        public virtual ICollection<SprintTask> SprintTasks { get; set; }
        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
