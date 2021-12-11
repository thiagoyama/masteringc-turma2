using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio02.Models
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public Produto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        //10%, 20% 
        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Preco - Preco * porcentagem/100;
        }
    }
}
