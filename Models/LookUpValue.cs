using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class LookUpValue
    {
        [NotMapped]
       public string LookUpCode { get; set; }
    }
}
