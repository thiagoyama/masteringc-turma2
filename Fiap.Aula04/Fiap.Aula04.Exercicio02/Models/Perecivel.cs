using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio02.Models
{
    class Perecivel : Produto
    {
        public DateTime DataValidade { get; set; }

        public Perecivel(int id, string nome, DateTime dataValidade) : base(id, nome)
        {
            DataValidade = dataValidade;
        }
    }
}
