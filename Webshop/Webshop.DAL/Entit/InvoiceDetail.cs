namespace Webshop.DAL.Entit
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int Pieces { get; set; }

        public InvoiceDetail(int pieces)
        {
            Pieces = pieces;
        }
    }
}
