using MGMT.Core.Entities.JobAggregate;
using MGMT.Core.Exceptions;
using MGMT.Core.Interfaces;
using MGMT.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Services
{
    public class JobService : IJobService
    {
        private readonly IRepository<Job> jobRepository;

        public JobService(IRepository<Job> jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        public async Task<Job> AddComment(int jobId, string content, int commentTypeId, DateTime reminderDate, int commenterId)
        {
            var job = await FindJob(jobId);

            job.AddComment(content, commentTypeId, reminderDate, commenterId);

            await jobRepository.UpdateAsync(job);

            return job;
        }

        public async Task<Job> CreateJobAsync(string name, string description, int jobTypeId, int creatorId, DateTime requiredByDate)
        {
            var job = new Job(name, description, jobTypeId, creatorId, requiredByDate);

            await jobRepository.AddAsync(job);

            return job;
        }

        public async Task DeleteJobAsync(int jobId)
        {
            var job = await FindJob(jobId);

            await jobRepository.DeleteAsync(job);
        }

        public async Task<Job> ChangeType(int jobId, int jobType)
        {
            var job = await FindJob(jobId);

            job.UpdateType(jobType);

            await jobRepository.UpdateAsync(job);

            return job;
        }

        private async Task<Job> FindJob(int jobId)
        {
            var jobSpec = new JobWithCommentsSpecification(jobId);

            var job = await jobRepository.FirstOrDefaultAsync(jobSpec);

            if (job == null)
            {
                throw new JobNotFoundException(jobId);
            }

            return job;
        }
    }
}
