using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public CatalogItem Item { get; set; }
        public int Qty { get; set; }
        public decimal LineTotal { get; set; }
    }
}
