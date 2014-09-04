using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canonical.DomainModel
{
    public class SalesOrderCreationMethod : Entity<long>
    {
        public string Name { get; set; }

        public static readonly SalesOrderCreationMethod Online = new SalesOrderCreationMethod { Id = 1, Name = "Online" };
        public static readonly SalesOrderCreationMethod Phone = new SalesOrderCreationMethod { Id = 0, Name = "Phone" };
        public static readonly SalesOrderCreationMethod Mail = new SalesOrderCreationMethod { Id = 2, Name = "Mail" };
    }
}
