using System;

namespace Fiap.Aula02.Exercicio.Models
{
    class ContaCorrente
    {
        //Propriedades
        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente Cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }

        //Métodos
        public bool Depositar(decimal valor)
        {
            if (valor > 0) //valida se o valor do depósito é positivo
            {
                Saldo += valor;
                return true;
            }
            return false;
        }

        public bool Retirar(decimal valor)
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
            if ((Especial && valor <= Saldo + Limite) || (valor <= Saldo))
            {
                Saldo -= valor;
                return true;
            }
            return false;
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

        public bool TransferirParaPoupanca(decimal valor)
        {
            if (Retirar(valor)) //Chama o método da própria classe
            {
                ContaPoupanca.Depositar(valor); //Chama o método do Objeto da ContaPoupanca
                return true;
            }
            return false;
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
