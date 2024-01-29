using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Person
    {
        public Person()
        {
            Orders = new HashSet<Order>();
        }

        public int Pid { get; set; }
        public string FerstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
