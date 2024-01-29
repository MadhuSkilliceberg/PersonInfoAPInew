using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Country
    {
        public Country()
        {
            CompanyAddresses = new HashSet<CompanyAddress>();
            CoutryStates = new HashSet<CoutryState>();
            InstitutionAddresses = new HashSet<InstitutionAddress>();
            UserAddressDetails = new HashSet<UserAddressDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }
        public virtual ICollection<CoutryState> CoutryStates { get; set; }
        public virtual ICollection<InstitutionAddress> InstitutionAddresses { get; set; }
        public virtual ICollection<UserAddressDetail> UserAddressDetails { get; set; }
    }
}
