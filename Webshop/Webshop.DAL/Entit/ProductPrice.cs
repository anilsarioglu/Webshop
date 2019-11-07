using System;

namespace Webshop.DAL.Entit
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public decimal ProductPrices { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndTime { get; set; }
    }
}
