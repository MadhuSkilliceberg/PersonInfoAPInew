using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class UserTokenSession
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string AccessToken { get; set; }
        public string DeviceType { get; set; }
        public string OperatingSystem { get; set; }
        public string BrowserInfo { get; set; }
        public DateTime? LoginTime { get; set; }
        public bool? IsActive { get; set; }
        public Guid? SessionId { get; set; }
        public string IpAddress { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? TokenExpires { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual User User { get; set; }
    }
}
