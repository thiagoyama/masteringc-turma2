using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.Exercicio.Models
{
    abstract class Conta
    {
        public decimal Saldo { get; protected set; }
        public double Numero { get; set; }

        public void Depositar(decimal valor)
        {
            if (valor < 0) //valida se o valor de depósito é positivo
            {
                throw new ArgumentException("O valor não pode ser negativo");
            }
            Saldo += valor; //Saldo = Saldo + valor;
        }
    }
}
