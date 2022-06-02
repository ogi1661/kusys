using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using KUSYS.Core.Models;

namespace KUSYS.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Students>
    {
        public void Configure(EntityTypeBuilder<Students> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.ToTable("Students");

        }
    }
}
