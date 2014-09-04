using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canonical.DomainModel
{
    public class PurchaseOrder
    {
        public ICollection<PurchaseOrderLineItem> LineItems { get; set; }

        public Vendor Vendor { get; set; }
    }
}
