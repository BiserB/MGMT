using MGMT.Core.Entities.JobAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MGMT.Infrastructure.Data.Config
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            var navigation = builder.Metadata.FindNavigation(nameof(Job.Comments));
            navigation?.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.HasKey(j => j.Id);

            builder.HasOne(j => j.JobType)
                .WithMany()
                .HasForeignKey(j => j.JobTypeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(j => j.JobStatus)
                .WithMany()
                .HasForeignKey(j => j.JobStatusId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(j => j.Creator)
                .WithMany()
                .HasForeignKey(j => j.CreatorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(j => j.Name).HasMaxLength(256).IsRequired();

            builder.Property(j => j.Description).HasMaxLength(32767);
        }
    }
}
