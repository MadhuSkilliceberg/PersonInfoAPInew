using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.CoustumModels
{
    public class InstitutionCourseList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InstitutionName { get; set; }
        public string CourseName { get; set; }
        public bool? IsActive { get; set; }
    }
}
