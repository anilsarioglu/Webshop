using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.DAL.Entit;

namespace Webshop.DAL.Configuration
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            this.ToTable("Course");
            this.Property(c => c.Id);
            this.Property(c => c.Name).HasMaxLength(100);
            this.Property(c => c.price).HasPrecision(8, 2);

        }
    }
}
