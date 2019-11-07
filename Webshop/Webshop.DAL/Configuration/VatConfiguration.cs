using System.Data.Entity.ModelConfiguration;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Configuration
{
    public class VatConfiguration : EntityTypeConfiguration<Vat>
    {
        public VatConfiguration()
        {
            this.ToTable("Vat");
            this.Property(v => v.Id).HasColumnType("int");
            this.Property(v => v.Percentage).HasColumnType("int");
        }
    }
}
