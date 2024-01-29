using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class MenuList
    {
        public int MId { get; set; }
        public int? MPId { get; set; }
        public string MName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
    }
}
