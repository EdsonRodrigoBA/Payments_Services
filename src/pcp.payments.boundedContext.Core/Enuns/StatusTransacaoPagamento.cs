using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Core.Enuns
{

    public enum StatusTransacaoPagamento
    {
        [Description("Autorizado")]
        Autorizado = 1,

        [Description("Negado")]
        Negado = 2,


    }
}
