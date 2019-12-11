using System;
using System.ComponentModel.DataAnnotations;

namespace Webshop.DAL.Entit
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public decimal ProductPrices { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndTime { get; set; }
        [Required]
        public Product Product { get; set; }

        public ProductPrice(decimal productPrices, DateTime beginDate, DateTime endTime, Product product)
        {
            ProductPrices = productPrices;
            BeginDate = beginDate;
            EndTime = endTime;
            Product = product;
        }

        public ProductPrice()
        {
            
        }
    }
}
