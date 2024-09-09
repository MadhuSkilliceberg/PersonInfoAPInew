using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Adattendance
    {
        public int AttendanceId { get; set; }
        public int? UserId { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public decimal? HoursWorked { get; set; }
        public decimal? OvertimeHours { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual User User { get; set; }
    }
}
