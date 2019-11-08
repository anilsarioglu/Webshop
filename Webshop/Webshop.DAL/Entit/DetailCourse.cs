namespace Webshop.DAL.Entit
{
    public class DetailCourse
    {
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public InvoiceDetail InvoiceDetail { get; set; }
        public int InvoiceDetailId { get; set; }
    }
}
