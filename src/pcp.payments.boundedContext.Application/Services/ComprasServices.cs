using AutoMapper;
using pcp.payments.boundedContext.Application.ViewModels;
using pcp.payments.boundedContext.Domain.Entities;
using pcp.payments.boundedContext.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Application.Services
{
    /// <summary>
    /// Classe que orquestra as regras do negocio e faz comunicação com a camada de infra.
    /// </summary>
    public class ComprasServices : ICompraServices
    {
        private readonly ICompraRepository _produtoRepository;

        private readonly IMapper _mapper;

        public ComprasServices(ICompraRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<CompraViewModel> AtualizarDadosPagamento(PagamentoViewModel pagamento)
        {
            pagamento.criadoEm = DateTime.Now;
            var pagamentoModel = _mapper.Map<Pagamento>(pagamento);
            await _produtoRepository.AtualizarDadosPagamento(pagamentoModel);
            await _produtoRepository.unitOfWork.Commit();

            var compraAtualizada = await  _produtoRepository.GetCompras(pagamento.compraId);
            return _mapper.Map<CompraViewModel>(compraAtualizada);
        }
    }
}
