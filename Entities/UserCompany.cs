﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserCompany
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public int? YearOfPassout { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? Salary { get; set; }
        public int? Percentage { get; set; }
        public int? DesignationId { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual User User { get; set; }
    }
}
