using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Chat
    {
        public Chat()
        {
            InverseParent = new HashSet<Chat>();
        }

        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? ParentId { get; set; }
        public int? ToUserId { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public int? EditableTimeSpan { get; set; }
        public int? OrderId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Group Group { get; set; }
        public virtual Chat Parent { get; set; }
        public virtual User ToUser { get; set; }
        public virtual ICollection<Chat> InverseParent { get; set; }
    }
}
