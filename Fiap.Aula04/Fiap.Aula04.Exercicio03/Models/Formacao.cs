using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio03.Models
{
    class Formacao
    {
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public decimal Mensalidade { get; set; }
        public Instituicao Instituicao { get; set; }

        public Formacao(string nome)
        {
            Nome = nome;
        }

        public void DefinirDuracao() { }

        public float CalcularMedia(float nota1, float nota2)
        {
            return 0;
        }

        public float CalcularMedia(float nota1, float nota2, float nota3)
        {
            return 0;
        }

        public virtual decimal CalcularMensalidade()
        {
            return 0;
        }
    }
}
