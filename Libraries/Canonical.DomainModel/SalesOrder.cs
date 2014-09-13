using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canonical.DomainModel
{
    public class SalesOrder
    {
        public long Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShipDate { get; set; }

        public SalesOrderStatus Status { get; set; }

        public SalesOrderCreationMethod CreationMethod { get; set; }

        public Customer Customer { get; set; }

        public Contact Contact { get; set; }

        public SalesPerson SalesPerson { get; set; }

        public ICollection<SalesOrderDetail> SalesOrderDetailList { get; set; }
    }
}
