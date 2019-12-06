namespace Webshop.DAL.Entit
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public InvoiceDetail InvoiceDetail { get; set; }
        public Product Product { get; set; }

        public Course(string name, decimal price, InvoiceDetail invoiceDetail, Product product)
        {
            Name = name;
            Price = price;
            InvoiceDetail = invoiceDetail;
            Product = product;
        }
        public Course()
        {

        }
    }
}
