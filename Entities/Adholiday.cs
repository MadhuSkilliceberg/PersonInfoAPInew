using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Adholiday
    {
        public int HolidayId { get; set; }
        public string HolidayName { get; set; }
        public DateTime? HolidayDate { get; set; }
        public string Description { get; set; }
        public bool? IsMandatory { get; set; }
    }
}
