using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Core.DomainObjects
{
    /// <summary>
    /// Entidade que compartilha recursos comuns entre os objetos de dominio
    /// </summary>
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime criadoEm { get; set; }
        public EntityBase()
        {
            if (Id.Equals(Guid.Empty))
            {
                Id = Guid.NewGuid();

            }
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as EntityBase;
            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(EntityBase a, EntityBase b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(EntityBase a, EntityBase b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id= {Id}]";
        }
    }
}
