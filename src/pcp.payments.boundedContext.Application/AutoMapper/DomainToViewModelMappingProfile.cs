using AutoMapper;
using pcp.payments.boundedContext.Application.ViewModels;
using pcp.payments.boundedContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Application.AutoMapper
{
    /// <summary>
    /// Classe que configura o mapeamento dos objetos de dominio para viewmodel
    /// 
    /// </summary>
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Compra, CompraViewModel>();
            CreateMap<Pagamento, PagamentoViewModel>();


        }

    }
}
