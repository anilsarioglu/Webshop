using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPdf;

namespace Webshop.BL
{
    public static class GeneratePDF
    {
        public static void CreatePDF()
        {
            HtmlToPdf renderer = new HtmlToPdf();
            renderer.RenderHtmlAsPdf("<h1>Hello World</h1>").SaveAs("..\\..\\test.pdf");
        }
    }
}
