using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canonical.DomainModel
{
    public class Vendor
    {
        public long Id { get; set; }

        public string AccountNumber { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public DateTime Modified { get; set; }

        public Uri Url { get; set; }

        public VendorStatus Status { get; set; }

        public CreditRating CreditRating { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
