using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoV2Api.Entities
{
    public partial class Task
    {
        public Task()
        {
            SprintTasks = new HashSet<SprintTask>();
            TaskComments = new HashSet<TaskComment>();
            TaskDocuments = new HashSet<TaskDocument>();
            TaskLogs = new HashSet<TaskLog>();
            TaskStates = new HashSet<TaskState>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ICollection<SprintTask> SprintTasks { get; set; }
        public virtual ICollection<TaskComment> TaskComments { get; set; }
        public virtual ICollection<TaskDocument> TaskDocuments { get; set; }
        public virtual ICollection<TaskLog> TaskLogs { get; set; }
        public virtual ICollection<TaskState> TaskStates { get; set; }
    }
}
