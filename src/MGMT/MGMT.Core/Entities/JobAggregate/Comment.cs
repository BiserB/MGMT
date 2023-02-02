using MGMT.Core.Entities.WorkerAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Entities.JobAggregate
{
    public class Comment : BaseEntity
    {
        public Comment(int jobId, int commentTypeId, string content, DateTime reminderDate, string commenterId)
        {
            JobId = jobId;
            CommentTypeId = commentTypeId;
            Content = content;
            ReminderDate = reminderDate;
            CommenterId = commenterId;
            CreatedOn = DateTime.UtcNow;
        }

        public int JobId { get; private set; }

        public int CommentTypeId { get; private set; }

        public CommentType CommentType { get; private set; }

        public string Content { get; private set; }

        public DateTime ReminderDate { get; private set; }

        public string CommenterId { get; private set; }

        public Worker Commenter { get; private set; }

        public DateTime CreatedOn { get; private set; }
    }
}
