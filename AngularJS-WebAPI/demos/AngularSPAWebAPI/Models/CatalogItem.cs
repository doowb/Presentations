using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public int CatalogId { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
    }
}
