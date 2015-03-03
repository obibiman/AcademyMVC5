using Academy.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.DataAccess.Mapping
{
    public class CourseMap : EntityTypeConfiguration<Course>
    {
        public CourseMap()
        {
            ToTable("Course");
            HasKey(t => t.CourseId);
            Property(t => t.CourseId).IsRequired().HasColumnName("CourseId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnType("INT");

            HasRequired(t => t.Department);
            Property(t => t.Abbreviation).IsRequired().HasColumnName("Abbreviation").HasMaxLength(4).HasColumnType("NVARCHAR");
            Property(t => t.Title).IsRequired().HasColumnName("Title").HasMaxLength(100).HasColumnType("NVARCHAR");
            Property(t => t.Description).IsRequired().HasColumnName("Description").HasMaxLength(200).HasColumnType("NVARCHAR");
            Property(t => t.Credit).IsOptional().HasColumnName("Credit").IsOptional().HasColumnType("INT");
            Property(t => t.ModifiedBy).IsOptional().HasColumnName("ModifiedBy").HasMaxLength(50).HasColumnType("NVARCHAR");
            Property(t => t.ModifiedDate).IsOptional().HasColumnName("ModifiedDate").HasColumnType("DateTime");

        }
    }
 }
