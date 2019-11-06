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
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public Vat Vat { get; set; }
        public int VatId { get; set; }
        public ProductPrice ProductPrice { get; set; }
        public int ProductPriceId { get; set; }
    }
}
