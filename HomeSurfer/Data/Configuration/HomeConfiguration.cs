using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeSurferModels;

namespace Data.Configuration
{
    public class HomeConfiguration:EntityTypeConfiguration<Home>
    {
        public HomeConfiguration()
        {
            this.Property(p => p.Id).HasColumnOrder(1);
            this.Property(p => p.Description).HasMaxLength(100);
            this.Property(p => p.Address1).IsRequired().HasMaxLength(100);
            this.Property(p => p.Address2).HasMaxLength(100);
            this.Property(p => p.City).IsRequired().HasMaxLength(50);
            this.Property(p => p.ZipCode).IsRequired().HasMaxLength(15);
            this.Property(p => p.Image).HasMaxLength(100);
            this.Property(p => p.CreatedOn).HasColumnType("datetime");
            this.Property(p => p.ModifiedOn).HasColumnType("datetime");
        }
    }
}
