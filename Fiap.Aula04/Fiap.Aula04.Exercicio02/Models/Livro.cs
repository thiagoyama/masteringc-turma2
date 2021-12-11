using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio02.Models
{
    class Livro : Produto
    {
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(int id, string nome, string autor) : base(id, nome)
        {
            Autor = autor;
        }

    }
}
