using System.Data.Entity.ModelConfiguration;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Configuration
{
    public class InvoiceConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
        {
            this.ToTable("Invoice");
            this.Property(i => i.Id).HasColumnType("int");
            this.Property(i => i.Date).HasColumnType("Date");
            this.Property(i => i.IsPaid).HasColumnType("Bit");
            this.Property(i => i.InvoiceCode).HasColumnType("Varchar");
            //this.HasMany(i => i.InvoiceDetails)
            //    .WithRequired(i => i.Invoice);
        }
    }
}
