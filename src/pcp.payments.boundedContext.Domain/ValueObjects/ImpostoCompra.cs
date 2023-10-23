// Copyright (c) Portal de Compras Públicas. Todos os direitos reservados.
// Este arquivo é parte do projeto PortalCompras, e é um projeto privado.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pcp.payments.boundedContext.Core.DomainObjects;

namespace pcp.payments.boundedContext.Domain.ValueObjects
{
    public class ImpostoCompra
    {
        public decimal valorImposto { get; private set; }
        public decimal aliquotaImposto { get; private set;}
        public string observacaoIposto { get; set; }

        public ImpostoCompra(decimal aliquotaImposto, decimal valorCompra)
        {
            Validacoes.ValidarMinimoMaximo(aliquotaImposto, 1, 18, "A Aliquota do Imposto deve esta entre 1 e 18");
            Validacoes.ValidarSeMenorQueMinimo(valorCompra, 00.1M, "O valor de compra  é invalido.");

            this.aliquotaImposto = aliquotaImposto;
            valorImposto = CalcularValorImposto(valorCompra);
            observacaoIposto = ObservacoImpostoFormat();


        }

        public decimal CalcularValorImposto(decimal valorCompra)
        {
            return  valorCompra * (aliquotaImposto / 100);
        }
        public string ObservacoImpostoFormat()
        {
            return $"O imposto pra esse tipo de compra é obirgatorio Aliquita Aplicada {aliquotaImposto} Todal do Imposto {valorImposto.ToString("C")}";
        }
    }
}
