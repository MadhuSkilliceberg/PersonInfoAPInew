﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class YearSemester
    {
        public int Id { get; set; }
        public int? CyearsId { get; set; }
        public int? SemesterId { get; set; }
        public int? OrderId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Cyear Cyears { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
