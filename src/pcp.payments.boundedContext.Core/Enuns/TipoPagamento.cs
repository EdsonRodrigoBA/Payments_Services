using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Core.Enuns
{
    public enum TipoPapagamento
    {
        [Description("CartaoDeCredito")]
        CartaoDeCredito = 1,

        [Description("CartaoDeDedito")]
        CartaoDeDebito = 2,

        [Description("Pix")]
        Pix = 3
    }
}
