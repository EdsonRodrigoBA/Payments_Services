using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pcp.payments.boundedContext.Application.Services;
using pcp.payments.boundedContext.Application.Validators;
using pcp.payments.boundedContext.Application.ViewModels;

namespace pcp.payments.boundedContext.WebApi.Payments.Controllers
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]

    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly ICompraServices _compraServices;
        IValidator<PagamentoViewModel> _validator;

        public PaymentsController(ICompraServices compraServices, IValidator<PagamentoViewModel> validator)
        {
            _compraServices = compraServices;
            _validator = validator;
        }

        /// <summary>
        /// Cria uma nova atualização de Pagamento
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///  {
        ///      "compraId": ""
        ///      "valor": 0,
        ///      "dataPagamento": "2023-10-11 17:50",
        ///      "status": 1,
        ///      "tipoPagamento": 1,
        ///    
        ///   }     
        ///</remarks>
        /// <returns>Uma compra processada</returns>
        /// <response code="201">Retorna Uma compra processada</response>
        /// <response code="400">Retorna erros de validação de campos do dominio</response>
        [HttpPost]
        [ProducesResponseType((201), Type = typeof(PagamentoViewModel))]
        [ProducesResponseType((400), Type = typeof(List<PagamentoViewModel>))]
        [ProducesResponseType((500))]
        [Produces("application/json")]

        public async Task<IActionResult> Post(PagamentoViewModel model)
        {
            model.compraId = Guid.NewGuid();
            var validation = await _validator.ValidateAsync(model);

            if (!validation.IsValid)
            {
                var errosr = validation.GetErrors();

                return BadRequest(validation.GetErrors());
            }
            model.Id = Guid.Empty;
            var produto = await _compraServices.AtualizarDadosPagamento(model);
            return StatusCode(StatusCodes.Status201Created, produto);
        }
    }
}
