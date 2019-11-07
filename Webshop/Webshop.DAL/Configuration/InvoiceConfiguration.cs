using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Property(i => i.Betaald).HasColumnType("Bit");
            this.Property(i => i.InvoiceCode).HasColumnType("Varchar");
            
        }
    }
}
