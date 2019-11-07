using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Configuration
{
    public class ProductPriceConfiguration : EntityTypeConfiguration<ProductPrice>
    {
        public ProductPriceConfiguration()
        {
            this.ToTable("ProductPrice");
            this.Property(pp => pp.Id).HasColumnType("int");
            this.Property(pp => pp.BeginDate).HasColumnType("Date");
            this.Property(pp => pp.EndTime).HasColumnType("Date");
            this.Property(pp => pp.ProductPrices).HasColumnType("decimal").HasPrecision(8, 2);
        }
    }
}
