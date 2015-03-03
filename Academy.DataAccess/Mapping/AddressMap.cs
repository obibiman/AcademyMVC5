using Academy.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.DataAccess.Mapping
{
    public class AddressConfig : ComplexTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            Property(t => t.Street).HasColumnName("Street").HasMaxLength(75).HasColumnType("NVARCHAR");
            Property(t => t.City).HasColumnName("City").HasMaxLength(50).HasColumnType("NVARCHAR");
            Property(t => t.State).HasColumnName("State").HasMaxLength(2).HasColumnType("NVARCHAR");
            Property(t => t.Zip).HasColumnName("Zip").HasMaxLength(10).HasColumnType("NVARCHAR");
        }
    }
}
