using pcp.payments.boundedContext.Core.DomainObjects;

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
