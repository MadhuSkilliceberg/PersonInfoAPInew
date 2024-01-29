﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class TaskComment
    {
        public TaskComment()
        {
            TaskCommentDocuments = new HashSet<TaskCommentDocument>();
        }

        public int Id { get; set; }
        public int? TaskId { get; set; }
        public string Comments { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Task Task { get; set; }
        public virtual ICollection<TaskCommentDocument> TaskCommentDocuments { get; set; }
    }
}
