using Microsoft.EntityFrameworkCore;
using pcp.payments.boundedContext.Core.Data;
using pcp.payments.boundedContext.Domain.Entities;
using pcp.payments.boundedContext.Domain.Interfaces;
using pcp.payments.boundedContext.Infraestructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Infraestructure.Repository
{
    public class CompraRepository : ICompraRepository
    {
        private readonly pcpEntityFrameworkDbContext _context;

        public CompraRepository(pcpEntityFrameworkDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork unitOfWork => _context;

        public async Task<Compra> AtualizarDadosPagamento(Pagamento pagamento)
        {
          
            var compraAtual = await _context.compras.FirstOrDefaultAsync(c => c.Id ==  pagamento.compraId);
            if(compraAtual == null)
            {
                 compraAtual = new Compra(Guid.NewGuid(), 100);
                compraAtual.Id = pagamento.compraId;
                compraAtual.AtualizarDataUltimoPagamento(pagamento.dataPagamento);
                compraAtual.pagamento = new List<Pagamento>() { pagamento };
                await _context.AddAsync(compraAtual);
            }
            else
            {
                compraAtual.AtualizarDataUltimoPagamento(pagamento.dataPagamento);
                compraAtual.pagamento = new List<Pagamento>() { pagamento };
                 _context.Update(compraAtual);
            }

            return compraAtual;
        }
        public async Task<Compra> GetCompras(Guid Id)
        {
            var compraAtual = await _context.compras.Include(p => p.pagamento).FirstOrDefaultAsync(c => c.Id == Id);
            return compraAtual;

        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
