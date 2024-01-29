using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.CoustumModels
{
    public class InstitutionModels
    {
        public Institution institutions { get; set; }
        public InstitutionAddress institutionaddress { get; set; }
        public InstitutionCourse institutionCourses { get; set; }
        public InstitutionContact institutioncontacts  { get; set; }
        public InstitutionEmail institutionemail { get; set; }
}


    public class InstitutionDetails
    {
        public  Institution institutions { get; set; }
        public List< InstitutionAddress> institutionaddress { get; set; }
        public List< InstitutionCourse> institutionCourses { get; set; }
        public List< InstitutionContact> institutioncontacts { get; set; }
        public List<InstitutionEmail> institutionemail { get; set; }
    }
}




