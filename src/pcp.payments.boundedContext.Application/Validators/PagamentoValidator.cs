using FluentValidation;
using pcp.payments.boundedContext.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Application.Validators
{
    /// <summary>
    /// Faz a configuração pra validação dos campos obrigatorio da classe de pagamento.
    /// </summary>
    public class PagamentoValidator : AbstractValidator<PagamentoViewModel>
    {
        public PagamentoValidator()
        {
            RuleFor(c => c.compraId)
                .NotNull().WithMessage("O campo identificador da compra é obrigatório.");
            
            RuleFor(c => c.valor).GreaterThan(0).WithMessage("Informe o valor do pagamento");

            RuleFor(c => c.status)
            .NotNull().WithMessage("O campo status do pagamento é obrigatório.");

            RuleFor(c => c.tipoPagamento)
                .NotNull().WithMessage("O campo tipo do pagamento é obrigatório.");

        }
    }
}
