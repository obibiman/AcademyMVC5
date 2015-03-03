using Academy.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.DataAccess.Mapping
{
    public class EmailMap : EntityTypeConfiguration<Email>
    {
        public EmailMap()
        {
            ToTable("Email");
            HasKey(t => t.EmailId);
            Property(t => t.EmailId).IsRequired().HasColumnName("EmailId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).HasColumnType("BIGINT");
            Property(t => t.EmailAddress).IsRequired().HasColumnName("EmailAddress").HasMaxLength(100).HasColumnType("NVARCHAR");
        }
    } 
  
  }
