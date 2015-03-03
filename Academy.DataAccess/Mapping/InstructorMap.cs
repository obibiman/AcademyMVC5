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
    public class InstructorMap : EntityTypeConfiguration<Instructor>
    {
        public InstructorMap()
        {
            ToTable("Instructor");
            HasKey(t => t.InstructorId);
            Property(t => t.InstructorId).IsRequired().HasColumnName("InstructorId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnType("INT");
            HasRequired(t => t.Department);
            HasRequired(t => t.ContactInfo);
            Property(t => t.HireDate).IsRequired().HasColumnName("HireDate").HasColumnType("DateTime");
            Property(t => t.ModifiedBy).IsOptional().HasColumnName("ModifiedBy").HasMaxLength(50).HasColumnType("NVARCHAR");
            Property(t => t.ModifiedDate).IsOptional().HasColumnName("ModifiedDate").HasColumnType("DateTime");
        }
    }
}