using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Application.ViewModels
{
    public class CompraViewModel
    {
        public Guid Id { get; set; }
        public Guid clienteId { get;  set; }
        public decimal valor { get;  set; }
        public DateTime dataUltimoPagamento { get;  set; }
        public List<PagamentoViewModel> pagamento { get; set; }

    }
}
