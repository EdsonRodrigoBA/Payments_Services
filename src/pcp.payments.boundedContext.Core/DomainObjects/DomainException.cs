using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Core.DomainObjects
{
    /// <summary>
    /// Classe de Exceção personalizada pra que nossos objetos de dominio possam se auto validar.
    /// </summary>
    public class DomainException : Exception
    {
        public DomainException()
        {

        }

        public DomainException(string message) : base(message)
        {

        }
        public DomainException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
