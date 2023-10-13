using pcp.payments.boundedContext.Core.DomainObjects;
using pcp.payments.boundedContext.Core.Enuns;
using pcp.payments.boundedContext.Domain.Entities;

namespace pcp.payments.boundedContext.Testes
{
    public class PagamentoDomainTeste
    {
        [Fact]
        public void Validar_Propriedades_Do_Objeto_De_Dominio_DeVe_Lancar_Exception()
        {
            var ex = Assert.Throws<DomainException>(() => new Pagamento(Guid.Empty, 100, DateTime.Now, StatusTransacaoPagamento.Autorizado, TipoPapagamento.Pix)
                ); ;
            Assert.Equal("O id da ordem de pagamento é obrigatorio.", ex.Message);
        }
    }
}