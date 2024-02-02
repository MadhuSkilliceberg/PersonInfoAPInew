using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Group
    {
        public Group()
        {
            Chats = new HashSet<Chat>();
            Events = new HashSet<Event>();
            News = new HashSet<News>();
        }

        public int Id { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPublic { get; set; }
        public int? AccessLevel { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
