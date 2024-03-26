using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;

namespace PersonsInfoV2Api.Models
{
    public class CompanyReviewModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ReviewId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedByName { get; set; }
        public string CreatedByName { get; set; }

        
        public string Heading { get; set; }
        public string Description { get; set; }
        public int? Rating { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPublic { get; set; }
        public int? AccessLevel { get; set; }

        public int TotalComments { get; set; }

        public  List<Review> Reviews { get; set; }
    }
}
