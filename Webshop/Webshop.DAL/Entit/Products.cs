using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.DAL.Entit
{
   public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Vat> Vats { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
       
    }
}
