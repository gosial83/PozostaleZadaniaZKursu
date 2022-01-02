using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex8.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ex8.Configuration
{
    public class StudentConfiguration: IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.PESEL).HasMaxLength(11).IsFixedLength().IsRequired();
            builder.Property(e => e.NumberOfAbsences).HasDefaultValue(0);
            builder.Property(e => e.Comment).HasMaxLength(255);
            builder.Property(e => e.Birthday).IsRequired();
            builder.Property(e => e.FathersName).HasMaxLength(100);
            builder.Property(e => e.MothersName).HasMaxLength(100);
        }
    }
}
