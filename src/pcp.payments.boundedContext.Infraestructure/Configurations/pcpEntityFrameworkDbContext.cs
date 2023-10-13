using Microsoft.EntityFrameworkCore;
using pcp.payments.boundedContext.Core.Data;
using pcp.payments.boundedContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Infraestructure.Configurations
{
    public class pcpEntityFrameworkDbContext : DbContext, IUnitOfWork
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "pcp_Payments_Db");

        }

        public DbSet<Pagamento> pagamentos { get; set; }
        public DbSet<Compra> compras { get; set; }




        /// <summary>
        /// Metodo que salva aplica as alterações na base de dados, verificando o estado de cada entidade
        /// e determinando se alguma propriedades que servem como log vão ser modificadas ou não.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Commit()
        {
            try
            {
                foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("criadoEm") != null))
                {
                    if (entry.State == EntityState.Added)
                    {
                        entry.Property("criadoEm").CurrentValue = DateTime.Now;
                    }

                    if (entry.State == EntityState.Modified)
                    {
                        entry.Property("criadoEm").IsModified = false;
                    }
                    if (entry.State == EntityState.Deleted)
                    {
                        entry.Property("criadoEm").IsModified = false;
                    }
                }

                return await base.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
