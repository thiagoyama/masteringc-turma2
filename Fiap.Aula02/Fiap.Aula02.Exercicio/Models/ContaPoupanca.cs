using Fiap.Aula02.Exercicio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.Exercicio.Models
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Propriedades
        //private set;  -> somente a classe ContaPoupanca pode modificar o Saldo diretamente
        public decimal Rendimentos { get; set; }

        //Construtor
        public ContaPoupanca(double numero)
        {
            Numero = numero;
        }

        //Métodos
        public void Retirar(decimal valor)
        {
            if (Saldo < valor)  //validar se o saldo é suficiente
            {
                throw new SaldoInsuficienteException($"Valor máximo para saque {Saldo}");
            }
            Saldo -= valor; //Saldo = Saldo - valor;
        }

        public decimal CalcularRetornoInvestimento(decimal taxa)
        {
            return Saldo * taxa;
        }

    }//class
}//namespace
