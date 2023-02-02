using MGMT.Core.Entities.JobAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Interfaces
{
    public interface IJobService
    {
        Task<Job> CreateJobAsync(string name, string description, int jobTypeId, string creatorId, DateTime requiredByDate);

        Task<Job> AddComment(int jobId, string content, int commentTypeId, DateTime reminderDate, string commenterId);

        Task DeleteJobAsync(int jobId);
    }
}
