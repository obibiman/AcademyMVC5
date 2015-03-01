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
            HasKey(x => x.StudentId);
            Property(x => x.StudentId).IsRequired().HasColumnName("StudentId").HasDatabaseGeneratedOption(
                DatabaseGeneratedOption.None).HasColumnType("BIGINT");

            Property(x => x.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasMaxLength(200)
                .HasColumnType("NVARCHAR");
            Property(x => x.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR");
            Property(x => x.ModifiedBy)
               .IsOptional()
               .HasColumnName("ModifiedBy")
               .HasMaxLength(50)
               .HasColumnType("NVARCHAR");
            Property(x => x.ModifiedDate).IsOptional().HasColumnName("ModifiedDate").HasColumnType("DateTime");

        }
    }
}
