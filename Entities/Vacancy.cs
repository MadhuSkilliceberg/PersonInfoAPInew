using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Vacancy
    {
        public Vacancy()
        {
            VacanciesSkills = new HashSet<VacanciesSkill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? IsActive { get; set; }
        public int CompanyId { get; set; }
        public int? Count { get; set; }
        public int? ExperienceFrom { get; set; }
        public int? ExperienceTo { get; set; }
        public int? StatusId { get; set; }
        public int? AppliedCount { get; set; }
        public int? RoleId { get; set; }
        public int? IndustryTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? EmploymentTypeId { get; set; }
        public int? RoleCategoryId { get; set; }
        public int? EducationTypeId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual Department1 Department { get; set; }
        public virtual EmploymentType EducationType { get; set; }
        public virtual EmploymentType EmploymentType { get; set; }
        public virtual IndustryType IndustryType { get; set; }
        public virtual Role Role { get; set; }
        public virtual RoleCategory RoleCategory { get; set; }
        public virtual Status Status { get; set; }
        public virtual User UpdatedByNavigation { get; set; }
        public virtual ICollection<VacanciesSkill> VacanciesSkills { get; set; }
    }
}
