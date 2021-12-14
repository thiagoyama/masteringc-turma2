using Fiap.Aula05.Models;
using System;

namespace Fiap.Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Estabelecimento
            //var e = new Estabelecimento(); Não é possível pois é abstrata

            //Instanciar uma Loja
            Loja loja = new Loja()
            {
                Cnpj = "12.321.321/0001-52",
                Nome = "FIAP Store",
                QuantidadeProdutos = 1000,
                //Atribuir um valor para o Tipo da Loja
                Tipo = TipoLoja.Eletronicos
            };

            //Validar se a loja é de Roupas
            if (loja.Tipo == TipoLoja.Roupa)
            {
                Console.WriteLine("A loja é de Roupas");
            }
            else
            {
                Console.WriteLine("A loja não é de Roupas");
            }

            //Chamar o método para CalcularImposto
            Console.WriteLine($"O imposto da loja é {loja.CalcularImposto(500)}");
        }
    }
}
