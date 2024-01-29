using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class CoutryState
    {
        public int Id { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
    }
}
