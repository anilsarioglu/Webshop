using System.Data.Entity.ModelConfiguration;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Configuration
{
    class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            this.ToTable("Product");
            this.Property(p => p.Id).HasColumnType("int");
            this.Property(p => p.Duration).HasColumnType("int");
            this.Property(p => p.EndDate).HasColumnType("Date");
            this.Property(p => p.StartDate).HasColumnType("Date");
            this.Property(p => p.Name).HasColumnType("varchar").HasMaxLength(150);
            
            
        }
    }
}
