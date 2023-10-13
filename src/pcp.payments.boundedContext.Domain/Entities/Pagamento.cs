using pcp.payments.boundedContext.Core.DomainObjects;
using pcp.payments.boundedContext.Core.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Domain.Entities
{
    public class Pagamento : EntityBase
    {
        public Guid compraId { get; private set; }
        public decimal valor { get; private set; }
        public DateTime dataPagamento { get; private set; }
        public StatusTransacaoPagamento status { get; private set; }
        public TipoPapagamento tipoPagamento { get; private set; }

        public Pagamento(Guid compraId, decimal valor, DateTime dataPagamento, StatusTransacaoPagamento status, TipoPapagamento tipoPagamento)
        {
            this.compraId = compraId;
            this.valor = valor;
            this.dataPagamento = dataPagamento;
            this.status = status;
            this.tipoPagamento = tipoPagamento;
            Validar();
        }

        public void Validar()
        {
            Validacoes.ValidarSeMenorQueMinimo(valor, 00.1M, "O valor do pagamento é invaldo");
            Validacoes.ValidaSeIgual(compraId, Guid.Empty, "O id da ordem de pagamento é obrigatorio.");
        }
    }
}
