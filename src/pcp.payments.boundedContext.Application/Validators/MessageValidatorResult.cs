using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Application.Validators
{
    /// <summary>
    /// Retorna os erros  de validação da cada propriedade dos objetos formatados.
    /// </summary>
    public class MessageValidatorResult
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public MessageValidatorResult(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
