using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canonical.DomainModel
{
    public class Entity<T>
    {
        public T Id { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this.GetType().IsInstanceOfType(obj))
                return false;
            var entity = (Entity<T>)obj;
            return entity.Id.Equals(this.Id);
        }
    }
}
