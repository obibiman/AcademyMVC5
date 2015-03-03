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
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            ToTable("Department");
            HasKey(t => t.DepartmentId);
            Property(t => t.DepartmentId).IsRequired().HasColumnName("DepartmentId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnType("BIGINT");
            Property(t => t.DepartmentName).IsRequired().HasColumnName("DepartmentName").HasMaxLength(50).HasColumnType("NVARCHAR");
            Property(t => t.DeptAbbrev).IsRequired().HasColumnName("DeptAbbrev").HasMaxLength(4).HasColumnType("NVARCHAR");
            Property(t => t.ModifiedBy).IsOptional().HasColumnName("ModifiedBy").HasMaxLength(50).HasColumnType("NVARCHAR");
            Property(t => t.ModifiedDate).IsOptional().HasColumnName("ModifiedDate").HasColumnType("DateTime");
        }
    }
}
