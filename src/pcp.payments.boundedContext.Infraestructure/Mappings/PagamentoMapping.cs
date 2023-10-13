using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pcp.payments.boundedContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Infraestructure.Mappings
{
    /// <summary>
    /// Classe que mapeia o tipo das propriedades dos objetos de dominio no banco de dados
    /// </summary>
    /// 

    /*public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        //public void Configure(EntityTypeBuilder<Pagamento> builder)
        //{
        //    builder.ToTable("Produtos");

        //    builder.HasKey(c => c.Id);

        //    builder.Property(c => c.nome)
        //        .IsRequired()
        //        .HasColumnType("varchar(250)");

        //    builder.Property(c => c.descricao)
        //        .IsRequired()
        //        .HasColumnType("varchar(500)");

        //    builder.Property(c => c.valor)
        //        .IsRequired()
        //        .HasColumnType("numeric(18,2");



        //}
    }*/
}
