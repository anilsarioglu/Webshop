namespace Webshop.DAL.Entit
{
    class DetailCourse
    {
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public InvoiceDetail InvoiceDetail { get; set; }
        public int InvoiceDetailId { get; set; }
    }
}
