namespace Webshop.DAL.Entit
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int Pieces { get; set; }
        public Invoice Invoice { get; set; }

        public InvoiceDetail()
        {
            
        }
        public InvoiceDetail(int pieces, Invoice invoice)
        {
            Pieces = pieces;
            Invoice = invoice;
        }
    }
}
