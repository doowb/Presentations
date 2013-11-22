using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime DueDate { get; set; }
        public IEnumerable<InvoiceItem> Items { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public string BillTo { get; set; }
        public string BillFrom { get; set; }
    }
}
