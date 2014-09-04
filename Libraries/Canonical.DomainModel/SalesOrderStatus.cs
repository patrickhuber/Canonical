using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canonical.DomainModel
{
    public class SalesOrderStatus : Entity<long>
    {
        public string Name { get; set; }

        public static readonly SalesOrderStatus InProcess = new SalesOrderStatus { Id = 1, Name = "In Process" };
        public static readonly SalesOrderStatus Approved = new SalesOrderStatus { Id = 2, Name = "Approved" };
        public static readonly SalesOrderStatus BackOrdered = new SalesOrderStatus { Id = 3, Name = "Back Ordered" };
        public static readonly SalesOrderStatus Rejected = new SalesOrderStatus { Id = 4, Name = "Rejected" };
        public static readonly SalesOrderStatus Shipped = new SalesOrderStatus { Id = 5, Name = "Shipped" };
        public static readonly SalesOrderStatus Canceled = new SalesOrderStatus { Id = 6, Name = "Canceled" };
    }
}
