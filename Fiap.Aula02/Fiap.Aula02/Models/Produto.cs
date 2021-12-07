using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.Models
{
    class Produto
    {
        //Propriedades (Informações que o Objeto pode armazenar)
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string Marca { get; set; }

        //Métodos (Ações que o Objeto pode executar)
        public void ExibirDados()
        {
            Console.WriteLine($"Nome {Nome}, Preço {Preco}, Estoque {Estoque}, Marca {Marca}");
        }

        //Método calcula e retorna o valor do produto com o desconto informado
        public decimal CalcularDesconto(decimal valorDesconto)
        {
            decimal valorFinal = Preco - valorDesconto;
            return valorFinal;
            //return Preco - valorDesconto;
        }
    }
}
