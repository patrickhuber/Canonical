using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canonical.DomainModel
{
    public class PurchaseOrderLineItem
    {
        public long Id { get; set; }
        
        public PurchaseOrder PurchaseOrder { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }

        public Money UnitPrice { get; set; }

        public DateTime Modified { get; set; }
    }
}
