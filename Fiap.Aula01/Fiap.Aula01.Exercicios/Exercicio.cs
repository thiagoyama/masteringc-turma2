using System;

namespace Fiap.Aula01.Exercicios
{
    class Exercicio
    {
        static void Main(string[] args)
        {
            //Ler o custo de fábrica
            Console.WriteLine("Digite o preço de custo");
            double valor = double.Parse(Console.ReadLine());

            //Calcular o preço final (distribuidor 29%, imposto 46%)
            double valorDistribuidor = valor * 0.29;
            double valorImposto = valor * 0.46;
            double valorFinal = valor + valorDistribuidor + valorImposto;

            //Exibir o preço final
            Console.WriteLine($"O valor final é {valorFinal}, o valor do imposto {valorImposto}");
        }
    }
}
