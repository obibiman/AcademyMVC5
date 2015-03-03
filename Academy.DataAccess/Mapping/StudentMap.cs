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
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            ToTable("Student");
            HasKey(t =>t.StudentId);
            Property(t => t.StudentId).IsRequired().HasColumnName("StudentId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnType("INT");

            HasRequired(t => t.ContactInfo);
            Property(t =>t.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(200).HasColumnType("NVARCHAR");
            Property(t =>t.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(100).HasColumnType("NVARCHAR");
            Property(t =>t.Major).IsRequired().HasColumnName("Major").HasMaxLength(25).HasColumnType("NVARCHAR");
            Property(t =>t.Credit).IsRequired().HasColumnName("Credit").IsOptional().HasColumnType("INT");
            Property(t =>t.EnrollmentDate).IsRequired().HasColumnName("EnrollmentDate").HasColumnType("DateTime");
            Property(t =>t.DateOfBirth).IsRequired().HasColumnName("DateOfBirth").HasColumnType("DateTime");
            Property(t =>t.ModifiedBy).IsOptional().HasColumnName("ModifiedBy").HasMaxLength(50).HasColumnType("NVARCHAR");
            Property(t =>t.ModifiedDate).IsOptional().HasColumnName("ModifiedDate").HasColumnType("DateTime");

        }
    }
}
