using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.CoustumModels
{
    public class InstitutionEmailList
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Email { get; set; }
        public bool? IsPrimary { get; set; }
        public int? OrderId { get; set; }

    }
}
