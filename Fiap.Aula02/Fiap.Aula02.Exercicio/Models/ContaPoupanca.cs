using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.Exercicio.Models
{
    class ContaPoupanca
    {
        //Propriedades
        //private set;  -> somente a classe ContaPoupanca pode modificar o Saldo diretamente
        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public decimal Rendimentos { get; set; }

        //Métodos
        public bool Depositar(decimal valor)
        {
            if (valor > 0) //valida se o valor de depósito é positivo
            {
                Saldo += valor; //Saldo = Saldo + valor;
                return true;
            }
            return false;
        }

        public bool Retirar(decimal valor)
        {
            if (Saldo >= valor)  //validar se o saldo é suficiente
            {
                Saldo -= valor; //Saldo = Saldo - valor;
                return true;
            }
            return false;
        }

    }//class
}//namespace
