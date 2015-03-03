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
    public class TelephoneMap : EntityTypeConfiguration<Telephone>
    {
        public TelephoneMap()
        {
            ToTable("Telephone");
            HasKey(t => t.TelephoneId);
            Property(t => t.TelephoneId).IsRequired().HasColumnName("TelephoneId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnType("INT");
            Property(t => t.AreaCode).IsRequired().HasColumnName("AreaCode").HasMaxLength(3).HasColumnType("NVARCHAR");
            Property(t => t.Exchange).IsRequired().HasColumnName("Exchange").HasMaxLength(3).HasColumnType("NVARCHAR");
            Property(t => t.PhoneNumber).IsRequired().HasColumnName("PhoneNumber").HasMaxLength(4).HasColumnType("NVARCHAR");
            Property(t => t.Extension).IsOptional().HasColumnName("Extension").HasMaxLength(5).HasColumnType("NVARCHAR");
        }
    }
}
