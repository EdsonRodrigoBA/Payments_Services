using pcp.payments.boundedContext.Core.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Application.ViewModels
{
    public class PagamentoViewModel
    {
        public Guid Id { get; set; }
        public Guid compraId { get;  set; }
        public decimal valor { get;  set; }
        public DateTime dataPagamento { get;  set; }
        public StatusTransacaoPagamento status { get;  set; }
        public TipoPapagamento tipoPagamento { get;  set; }
        public DateTime criadoEm { get; set; }

    }
}
