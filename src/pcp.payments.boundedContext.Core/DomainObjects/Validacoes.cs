using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcp.payments.boundedContext.Core.DomainObjects
{
    /// <summary>
    /// Classe pra validação dos objetos de dominio ou sua propreiedade
    /// </summary>
    public class Validacoes
    {
        public static void ValidaSeIgual(object object1, object Object2, string mensagem)
        {
            if (object1.Equals(Object2))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidaSeDiferente(object object1, object Object2, string mensagem)
        {
            if (!object1.Equals(Object2))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidaTamanhoCaracteres(string valor, int maximo, string mensagem)
        {
            var length = valor.Length;
            if (length > maximo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidaTamanhoCaracteres(string valor, int minimo, int maximo, string mensagem)
        {
            var length = valor.Length;
            if (length > maximo || length < minimo)
            {
                throw new DomainException(mensagem);
            }
        }



        public static void ValidarSeVazio(string valor, string mensagem)
        {
            if (valor == null || valor.Trim().Length == 0)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeNulo(object obj, string mensagem)
        {
            if (obj == null)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeMenorQueMinimo(decimal valor, decimal minimo, string mensagem)
        {
            if (valor < minimo)
            {
                throw new DomainException(mensagem);
            }
        }
    }
}
