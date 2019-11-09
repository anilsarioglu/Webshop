using System.Data.Entity.ModelConfiguration;
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
            this.Property(c => c.Price).HasPrecision(8, 2);

        }
    }
}
