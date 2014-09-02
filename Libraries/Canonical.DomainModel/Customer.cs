using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canonical.DomainModel
{
    public class Customer
    {
        public long Id { get; set; }

        public ICollection<CustomerAddress> CustomerAddressList { get; set; }
    }
}
