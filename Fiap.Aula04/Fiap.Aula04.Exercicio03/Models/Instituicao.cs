using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio03.Models
{
    class Instituicao
    {
        public string Nome { get; set; }

        public Instituicao(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Instituição: {Nome}";
        }
    }
}
