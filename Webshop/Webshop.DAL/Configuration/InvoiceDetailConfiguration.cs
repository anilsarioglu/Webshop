using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Configuration
{
    public class InvoiceDetailConfiguration : EntityTypeConfiguration<InvoiceDetail>
    {
        public InvoiceDetailConfiguration()
        {
            this.ToTable("InvoiceDetail");
            this.Property(id => id.Id).HasColumnType("int");
            this.Property(id => id.Pieces).HasColumnType("int");
        }
    }
}
