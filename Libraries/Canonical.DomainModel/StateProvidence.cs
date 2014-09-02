using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Canonical.DomainModel
{
    public class StateProvidence
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CountryRegion CountryRegion { get; set; }
    }
}
