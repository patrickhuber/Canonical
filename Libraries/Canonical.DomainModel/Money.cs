using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canonical.DomainModel
{
    public class Money
    {
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
    }
}
