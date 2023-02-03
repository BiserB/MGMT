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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Commenter)
                .WithMany()
                .HasForeignKey(c => c.CommenterId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Job)
                .WithMany(j => j.Comments)
                .HasForeignKey(c => c.JobId)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(c => c.CommentType)
                .WithMany()
                .HasForeignKey(c => c.CommentTypeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.Content).HasMaxLength(2048).IsRequired();
        }
    }
}
