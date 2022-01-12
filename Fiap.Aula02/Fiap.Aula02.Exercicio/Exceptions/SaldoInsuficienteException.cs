using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.Exercicio.Exceptions
{
    class SaldoInsuficienteException : Exception
    {
        //Construtor que recebe uma mensagem
        public SaldoInsuficienteException(string msg) : base (msg)
        {

        }

    }
}
