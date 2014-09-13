using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canonical.DomainModel
{
    public class SalesOrderDetail
    {
        public int Id { get; set; }

        public SalesOrder SalesOrder { get; set; }

        public Product Product { get; set; }

        public int OrderQuantity { get; set; }

        public Money UnitPrice { get; set; } 
    }
}
