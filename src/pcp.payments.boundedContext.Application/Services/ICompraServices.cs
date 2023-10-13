using pcp.payments.boundedContext.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Application.Services
{
    public interface ICompraServices
    {
         Task<CompraViewModel> AtualizarDadosPagamento(PagamentoViewModel pagamento);

    }
}
