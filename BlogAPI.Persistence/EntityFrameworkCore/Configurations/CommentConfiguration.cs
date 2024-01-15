using BlogAPI.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.Persistence.Configurations
{
    internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Author)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.Content)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(c => c.CreationDate)
                .IsRequired();
        }
    }
}
