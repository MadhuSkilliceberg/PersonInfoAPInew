using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? TypeId { get; set; }
        public string Description { get; set; }
        public string Tempalte { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual TemplateType Type { get; set; }
    }
}
