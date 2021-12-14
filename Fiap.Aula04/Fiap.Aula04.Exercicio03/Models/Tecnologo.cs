using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio03.Models
{
    class Tecnologo : Formacao
    {
        public bool PlanoEstendido { get; set; }

        public Tecnologo(string nome) : base (nome) { }

        public override decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 500;
        }

        public override void DefinirDuracao()
        {
            Duracao = 24;
        }

        public override string ToString()
        {
            return base.ToString() + $" Plano estendido: {PlanoEstendido}";
        }
    }
}
