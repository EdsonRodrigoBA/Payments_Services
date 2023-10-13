using pcp.payments.boundedContext.Core.Data;
using pcp.payments.boundedContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Domain.Interfaces
{
    public interface ICompraRepository : IRepository<Compra>
    {
        public Task<Compra> AtualizarDadosPagamento(Pagamento pagamento);
        public Task<Compra>GetCompras(Guid Id);
    }
}
