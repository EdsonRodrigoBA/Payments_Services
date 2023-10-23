using pcp.payments.boundedContext.Core.DomainObjects;
using pcp.payments.boundedContext.Domain.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Domain.Entities
{
    public  class Compra : EntityBase, IAggregateRoot
    {
        public Guid clienteId { get; private set; }
        public decimal valor { get; private set; }
        public List<Pagamento>  pagamento { get;  set; }
        public DateTime dataUltimoPagamento { get; private set; }
        public ImpostoCompra imposto { get; set; }
        public Compra(Guid clienteId, decimal valor, ImpostoCompra imposto)
        {


            this.clienteId = clienteId;
            this.valor = valor;
            this.imposto = imposto;
            Validar();
        }

        public void AtualizarDataUltimoPagamento(DateTime dataPagamento)
        {
            dataUltimoPagamento = dataPagamento;
        }

        public void Validar()
        {
            Validacoes.ValidarSeMenorQueMinimo(valor, 00.1M, "O valor da compra é invalido.");
            Validacoes.ValidaSeIgual(clienteId, Guid.Empty, "O cliente informado na compra é invalido.");
            Validacoes.ValidarSeNulo(imposto, "O valor do Imposto  é invalido.");

        }
        public Compra() { }

    }
}
