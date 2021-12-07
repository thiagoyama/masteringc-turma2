using Fiap.Aula02.Models;
using System;

namespace Fiap.Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados do produto (Nome, Marca, Preço e Estoque)
            //var -> declara uma variável do tipo do valor associado a ela.
            Console.WriteLine("Digite o nome do produto");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a marca do produto");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o estoque do produto");
            int estoque = int.Parse(Console.ReadLine());

            //Instanciar um Produto 
            //ALT + Enter (Correção de problemas)
            Produto p = new Produto();

            //Atribuir as informações para o Objeto Produto
            p.Nome = nome;
            p.Marca = marca;
            p.Estoque = estoque;
            p.Preco = preco;

            //Chamar os métodos
            //Chamar o método ExibirDados()
            p.ExibirDados();

            //Calcular Desconto
            Console.WriteLine("Digite o desconto");
            var desconto = decimal.Parse(Console.ReadLine());
            decimal valor = p.CalcularDesconto(desconto);
            Console.WriteLine($"Valor do produto com desconto {valor}");
        }
    }
}
