using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserEmail
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Email { get; set; }
        public bool? IsPrimary { get; set; }
        public int? OrderId { get; set; }
        public int? TypeId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ContactType Type { get; set; }
        public virtual User User { get; set; }
    }
}
