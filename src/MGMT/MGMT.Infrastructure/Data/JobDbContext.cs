using MGMT.Core.Entities.JobAggregate;
using MGMT.Core.Entities.WorkerAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Infrastructure.Data
{
    public class JobDbContext : DbContext
    {
#pragma warning disable CS8618 // Required by Entity Framework
        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        { }

        public DbSet<Comment> Jobs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentType> CommentTypes { get; set; }
        public DbSet<JobStatus> JobStatuses { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
