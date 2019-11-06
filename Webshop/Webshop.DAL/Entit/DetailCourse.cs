using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
