using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using pcp.payments.boundedContext.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Application.Validators
{
    /// <summary>
    /// Classe que faz a configuração da injeção de dependencia e coleta os erros capturados pra o fluent validator
    /// </summary>
    public static class FluentValidationExtension
    {
        public static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {
            services.AddScoped<IValidator<PagamentoViewModel>, PagamentoValidator>();
            return services;
        }

        public static List<MessageValidatorResult>? GetErrors(this ValidationResult result)
        {
            return result.Errors?.Select(error => new MessageValidatorResult(error.PropertyName, error.ErrorMessage)).ToList();
        }
    }
}
