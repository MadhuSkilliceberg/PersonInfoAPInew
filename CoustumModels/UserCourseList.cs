using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.CoustumModels
{
    public class UserCourseList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsPrimary { get; set; }
        public string FirstName { get; set; }
        public int? OrderId { get; set; }
    }
}
