using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canonical.DomainModel
{
    public class IndividualCustomer : Customer
    {
        public Contact Contact { get; set; }
    }
}
