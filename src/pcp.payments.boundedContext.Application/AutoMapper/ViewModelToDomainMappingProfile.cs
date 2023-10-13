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
    /// Classe que configura o mapeamento de uma ViewModel para um objeto de dominio 
    /// 
    /// </summary>
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            CreateMap<PagamentoViewModel, Pagamento>()
            .ConstructUsing(p =>
            new Pagamento(p.compraId, p.valor, p.dataPagamento,
                p.status, p.tipoPagamento
            ));
        }
    }
}
