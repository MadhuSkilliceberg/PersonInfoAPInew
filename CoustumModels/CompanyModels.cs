using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.CoustumModels
{
    public class CompanyModels
    {
        public Company company { get; set; }
        public CompanyAddress companyAddress { get; set; }
        public CompanyContact CompanyContact { get; set; }
        public CompanyEmail companyEmail { get; set; }
        public CompanyReview companyReview { get; set; }
        
    }


    public class CompanyDetail
    {
        public Company company { get; set; }
        public List<CompanyAddress> companyaddress { get; set; }
        
        public List<CompanyContact> companyContacts { get; set; }
        public List<CompanyEmail> companyEmails { get; set; }
        public List<Review> companyReviews { get; set; }
    }
}
