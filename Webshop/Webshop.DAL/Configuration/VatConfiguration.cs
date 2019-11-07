using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Configuration
{
    public class VatConfiguration : EntityTypeConfiguration<Vat>
    {
        public VatConfiguration()
        {
            this.ToTable("Vat");
            this.Property(v => v.Id).HasColumnType("int");
            this.Property(v => v.Precentage).HasColumnType("int");
        }
    }
}
