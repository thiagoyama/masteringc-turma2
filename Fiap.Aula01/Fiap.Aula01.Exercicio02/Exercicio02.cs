using System;
using Fiap.Aula01.Exercicio02.Models;

namespace Fiap.Aula01.Exercicio02
{
    class Exercicio02
    {
        static void Main(string[] args)
        {
            //Ler os dados da cor 
            Console.WriteLine("Digite o nome da cor");
            string nomeCor = Console.ReadLine();

            Console.WriteLine("Digite o R da cor");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o G da cor");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o B da cor");
            int b = int.Parse(Console.ReadLine());

            //Instanciar uma Cor
            Cor cor = new Cor();
            //Atribuir os valores lidos no objeto Cor
            cor.Nome = nomeCor;
            cor.R = r;
            cor.G = g;
            cor.B = b;

            //Ler os dados do carro
            Console.WriteLine("Digite o Modelo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite o Ano");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento");
            double comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a placa");
            string placa = Console.ReadLine();

            Console.WriteLine("Digite o Valor");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Tem ar-condicionado? (true/false)");
            bool ar = bool.Parse(Console.ReadLine());

            //Criar um objeto do tipo Carro
            Carro carro = new Carro();
            //Atribuir os valores lidos no objeto Carro
            carro.Ano = ano;
            carro.ArCondicionado = ar;
            carro.Comprimento = comprimento;
            carro.Modelo = modelo;
            carro.Placa = placa;
            carro.Valor = valor;
            carro.Cor = cor;

            //Exibir os valores
            Console.WriteLine($"Modelo: {carro.Modelo}, Ano: {carro.Ano}, Comprimento: {carro.Comprimento}" +
                $" Placa: {carro.Placa}, Valor: {carro.Valor}, Ar-Condicionado: {carro.ArCondicionado}" +
                $" Cor: {carro.Cor.Nome}, ({carro.Cor.R},{carro.Cor.G},{carro.Cor.B})");

            //Instanciar um avião
            Aviao jato = new Aviao();

            //Instanciar uma lancha
            Lancha lancha = new Lancha();
        }
    }
}
