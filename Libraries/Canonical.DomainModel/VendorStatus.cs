using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canonical.DomainModel
{
    public class VendorStatus : Entity<long>
    {
        public string Name { get; set; }

        public static readonly VendorStatus Preferred = new VendorStatus { Id = 1, Name = "Preferred" };
        public static readonly VendorStatus Normal = new VendorStatus { Id = 0, Name = "Normal" };
    }
}
