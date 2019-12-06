namespace Webshop.DAL.Entit
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int Pieces { get; set; }
        public Invoice Invoice { get; set; }
        public Course Course { get; set; }
        public InvoiceDetail()
        {
            
        }
        public InvoiceDetail(int pieces, Invoice invoice, Course course)
        {
            Pieces = pieces;
            Invoice = invoice;
            Course = course;
        }
    }
}
