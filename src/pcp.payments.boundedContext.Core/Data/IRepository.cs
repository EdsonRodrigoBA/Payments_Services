using pcp.payments.boundedContext.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Core.Data
{
    /// <summary>
    /// Repositorio Generico
    /// </summary>
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork unitOfWork { get; }

    }
}
