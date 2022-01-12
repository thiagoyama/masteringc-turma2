using Fiap.Aula02.Exercicio.Exceptions;
using System;

namespace Fiap.Aula02.Exercicio.Models
{
    class ContaCorrente : Conta
    {
        //Propriedades
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente Cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }

        //Construtor
        public ContaCorrente(double numero, bool especial, decimal limite,
                        Cliente cliente, ContaPoupanca poupanca, double juros)
        {            
            Numero = numero;
            Especial = especial;
            Limite = limite;
            Cliente = cliente;
            ContaPoupanca = poupanca;
            Juros = juros;
        }

        //Métodos
        public void Retirar(decimal valor)
        {   /*
            if (Especial)
            {
                if (valor <= Saldo + Limite) //Valida se o valor é menor ou igual ao Saldo + Limite
                {
                    Saldo -= valor;
                    return true;
                }
                return false;
            }
            else
            {
                if (valor <= Saldo)
                {
                    Saldo -= valor;
                    return true;
                }
                return false;
            }*/
            //Se for especial E o valor for menor ou igual ao saldo + limite
            //OU se o valor for menor ou igual ao saldo
            if ( ! ((Especial && valor <= Saldo + Limite) || (valor <= Saldo)) )
            {
                throw new SaldoInsuficienteException("Saldo insuficiente");
            }
            Saldo -= valor;
        }

        public decimal RetornarSaldoTotal()
        {
            if (Especial)
            {
                return Saldo + Limite;
            }
            return Saldo;
            //Ternário -> condição ? Se verdadeiro : Se falso;
            //return Especial ? Saldo + Limite : Saldo;
        }

        public void TransferirParaPoupanca(decimal valor)
        {
            Retirar(valor); //Chama o método da própria classe
            ContaPoupanca.Depositar(valor); //Chama o método do Objeto da ContaPoupanca
        }

        public decimal CalcularValorTaxaJuros(int dias)
        {
            //Se estiver utilizando o limite, calcular o valor do juros de acordo com a propriedade e o nr de dias
            if (Saldo < 0)
            {
                //Converter um double para decimal
                return Convert.ToDecimal(Juros) * dias * Saldo;
            }
            return 0;
        }

    }//class
}//namespace
