using MGMT.Core.Entities.JobAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Infrastructure.Data.Config
{
    public class JobStatusConfiguration : IEntityTypeConfiguration<JobStatus>
    {
        public void Configure(EntityTypeBuilder<JobStatus> builder)
        {
            builder.HasKey(jt => jt.Id);

            builder.Property(jt => jt.Status)
               .IsRequired()
               .HasMaxLength(100);
        }
    }
}
