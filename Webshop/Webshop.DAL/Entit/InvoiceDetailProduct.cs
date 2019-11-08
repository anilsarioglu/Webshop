namespace Webshop.DAL.Entit
{
    class InvoiceDetailProduct
    {
        public InvoiceDetail InvoiceDetail { get; set; }
        public int InvoiceDetailId { get; set; }
        public Product Products { get; set; }
        public int ProductId { get; set; }
    }
}
