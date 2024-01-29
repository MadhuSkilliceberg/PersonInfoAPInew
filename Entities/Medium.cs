using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Medium
    {
        public Medium()
        {
            InstitutionAddresses = new HashSet<InstitutionAddress>();
            Institutions = new HashSet<Institution>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<InstitutionAddress> InstitutionAddresses { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
