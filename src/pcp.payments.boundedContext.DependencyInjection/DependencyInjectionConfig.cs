using Microsoft.Extensions.DependencyInjection;
using pcp.payments.boundedContext.Application.AutoMapper;
using pcp.payments.boundedContext.Application.Services;
using pcp.payments.boundedContext.Application.Validators;

using pcp.payments.boundedContext.Domain.Interfaces;
using pcp.payments.boundedContext.Infraestructure.Configurations;
using pcp.payments.boundedContext.Infraestructure.Repository;

namespace pcp.payments.boundedContext.DependencyInjection
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<pcpEntityFrameworkDbContext>();
            services.AddScoped<ICompraServices, ComprasServices>();
            services.AddScoped<ICompraRepository, CompraRepository>();
            services.AddFluentValidation();

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
            return services;
        }
    }
}