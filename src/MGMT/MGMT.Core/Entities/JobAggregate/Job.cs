using MGMT.Core.Entities.WorkerAggregate;
using MGMT.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Entities.JobAggregate
{
    public class Job : BaseEntity, IAggregateRoot
    {
        private readonly List<Comment> comments = new List<Comment>();

        public Job(string name, string description, int jobTypeId, string creatorId, DateTime requiredByDate)
        {
            Name = name;
            Description = description;
            JobTypeId = jobTypeId;
            CreatedOn = DateTime.UtcNow;
            CreatorId = creatorId;
            RequiredByDate = requiredByDate;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public int JobTypeId { get; private set; }

        public JobType JobType { get; private set; }

        public int JobStatusId { get; private set; }

        public JobStatus JobStatus { get; private set; }

        public DateTime CreatedOn { get; private set; }

        public string CreatorId { get; private set; }

        public DateTime RequiredByDate { get; private set; }

        public IReadOnlyCollection<Comment> Comments => comments.AsReadOnly();

        public void UpdateName(string name)
        {
            Name = name;
        }

        public void UpdateDescription(string description)
        {
            Description = description;
        }

        public void UpdateType(int jobTypeId)
        {
            JobTypeId = jobTypeId;
        }

        public void UpdateStatus(int jobStatusId)
        {
            JobStatusId = jobStatusId;
        }
        
        public void UpdateRequiredByDate(DateTime requiredByDate)
        {
            RequiredByDate = requiredByDate;
        }

        public void AddComment(string content, int commentTypeId, DateTime reminderDate, string commenterId)
        {
            if (String.IsNullOrWhiteSpace(content) || String.IsNullOrWhiteSpace(commenterId))
            {
                return;
            }

            comments.Add(new Comment(Id, commentTypeId, content, reminderDate, commenterId));
        }

        public void DeleteComment(int commentId, string workerId)
        {
            if (String.IsNullOrWhiteSpace(workerId))
            {
                return;
            }

            var commentToRemove = comments.Where(c => c.Id == commentId && c.CommenterId == workerId).FirstOrDefault();

            if (commentToRemove == null)
            {
                return;
            }

            comments.Remove(commentToRemove);
        }
    }
}
