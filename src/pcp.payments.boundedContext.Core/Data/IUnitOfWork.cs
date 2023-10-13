using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Core.Data
{
    /// <summary>
    /// 
    /// Classe responsavel por acompanhar e rasrtrear as alterações das entidades de negócio durante uma transação via EntityFramework,
    /// sendo também responsável pelo gerenciamento dos problemas de concorrência que podem ocorrer oriundos dessa transação.
    /// </summary>
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
