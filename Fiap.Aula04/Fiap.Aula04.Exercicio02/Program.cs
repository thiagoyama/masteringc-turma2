using Fiap.Aula04.Exercicio02.Models;
using System;

namespace Fiap.Aula04.Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um produto passando informações
            Produto sapato = new Produto(1, "Sapato social") 
            { 
                Preco = 100
            };

            //Instanciar um Eletronico passando informações
            Eletronico celular = new Eletronico(1, "Smartphone XPTO") 
            { 
                Preco = 1500,
                Garantia = true
            };

            //Instanciar o Perecível passando informações
            DateTime data = new DateTime(2021, 10, 15); //ano, mês, dia
            DateTime dataHoje = DateTime.Now; //Retorna o objeto com a data atual
            Perecivel arroz = new Perecivel(2, "Arroz Integral", dataHoje);

            //Exibir a data
            Console.WriteLine($"Data de validade: {arroz.DataValidade}");
            Console.WriteLine($"Data de validade só com data: {arroz.DataValidade.ToShortDateString()}");
            Console.WriteLine($"Dia: {arroz.DataValidade.Day}, Ano: {arroz.DataValidade.Year}");

            //Chamar os métodos
            var desconto = sapato.CalcularDesconto(10);
            Console.WriteLine($"Valor do sapato com desconto {desconto}");

            Console.WriteLine($"Valor da garantia estendida {celular.CalcularGarantiaEstendida()}");

        }
    }
}
