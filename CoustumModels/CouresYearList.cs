using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.CoustumModels
{
    public class CouresYearList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CYName { get; set; }
        public bool? IsActive { get; set; }
        public int? OrderId { get; set; }
    }
}
