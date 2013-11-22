using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace AngularSPAWebAPI.Models
{
    public class NewInvoiceViewModel
    {
        public string number { get; set; }
        public DateTime billingDate { get; set; }
        public DateTime dueDate { get; set; }
        public IEnumerable<InvoiceItem> items { get; set; }
        public decimal subtotal { get; set; }
        public decimal total { get; set; }
        public string billTo { get; set; }
        public string billFrom { get; set; }
    }
}