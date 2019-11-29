using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPdf;

namespace Webshop.BL
{
    internal static class GeneratePDF
    {
        internal static PdfDocument CreatePDF(string html)
        {
            HtmlToPdf renderer = new HtmlToPdf();
            return renderer.RenderHtmlAsPdf(html).SaveAs("..\\..\\test.pdf");
        }
    }
}
