using Fiap.Aula02.Exercicio.Models;
using System;

namespace Fiap.Aula02.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados do cliente (Nome, CPF, Telefone)
            Console.WriteLine("Digite o nome do cliente");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do cliente");
            var cpf = Console.ReadLine();

            Console.WriteLine("Digite o telefone do cliente");
            var tel = Console.ReadLine();

            //Ler os dados da conta corrente (Número, Especial, Limite, Juros)
            Console.WriteLine("Digite o numero da conta");
            int numeroCc = int.Parse(Console.ReadLine());

            Console.WriteLine("É uma conta especial? (true/false)");
            bool especial = bool.Parse(Console.ReadLine());

            decimal limite = 0;
            double juros = 0;

            if (especial) //Somente lê os dados se for especial
            {
                Console.WriteLine("Digite o limite da conta");
                limite = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o juros da conta");
                juros = double.Parse(Console.ReadLine());
            }

            //Ler os dados da conta poupança (Número)
            Console.WriteLine("Digite o número da conta poupança");
            double numeroPoupanca = double.Parse(Console.ReadLine());

            //Instanciar o Cliente (ALT + Enter)
            //CTRL + K + C (Comenta as linha selecionadas)
            //CTRL + K + U (Descomenta as linhas selecionadas)
            Cliente cliente = new Cliente(nome, tel, cpf);
            //cliente.Nome = nome;
            //cliente.Telefone = tel;
            //cliente.Cpf = cpf;

            //Instanciar a conta poupança
            ContaPoupanca cp = new ContaPoupanca(numeroPoupanca);
            //cp.Numero = numeroPoupanca;

            //Instanciar a conta corrente
            ContaCorrente cc = new ContaCorrente();
            cc.Numero = numeroCc;
            cc.Juros = juros;
            cc.Limite = limite;
            cc.Especial = especial;
            cc.ContaPoupanca = cp;
            cc.Cliente = cliente;

            int opcao;
            do
            {
                Console.WriteLine("Escolha uma opção: \n1-Depositar \n2-Retirar \n3-Transferir \n4-Calcular \n0-Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor para depósito");
                        var valor = decimal.Parse(Console.ReadLine()); //Ler o valor para depósito
                        cc.Depositar(valor); //Depositar o valor 
                        Console.WriteLine($"O Saldo da conta é {cc.Saldo} e o total {cc.RetornarSaldoTotal()}");
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor para retirar");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.Retirar(valor);
                        Console.WriteLine($"O Saldo da conta é {cc.Saldo} e o total {cc.RetornarSaldoTotal()}");
                        break;
                    case 3:
                        Console.WriteLine("Digite o valor para transferir");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.TransferirParaPoupanca(valor);
                        Console.WriteLine($"Saldo da conta {cc.Saldo}, total {cc.RetornarSaldoTotal()}");
                        Console.WriteLine($"Sado na poupança {cc.ContaPoupanca.Saldo}");
                        break;
                    case 4:
                        Console.WriteLine("Digite a quantidade de dias");
                        int dias = int.Parse(Console.ReadLine());
                        decimal valorJuros = cc.CalcularValorTaxaJuros(dias);
                        Console.WriteLine($"O valor dos juros é {valorJuros}");
                        break;
                    case 0:
                        Console.WriteLine("Finalizando o sistema");
                        break;
                    default:                        
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 0); //Repete enquanto a opção for diferente de zero (sair)

        }//main
    }//class
}//namespace
