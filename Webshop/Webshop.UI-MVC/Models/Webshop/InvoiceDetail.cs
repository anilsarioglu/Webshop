using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webshop.UI_MVC.Models.Webshop
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int Pieces { get; set; } 
            
      

        public InvoiceDetail()
        {

        }
        public InvoiceDetail(int pieces)
        {
            Pieces = pieces;

          
        }
    }
}
