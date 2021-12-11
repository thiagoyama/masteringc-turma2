using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio03.Models
{
    class Bacharelado : Formacao
    {
        public string ProjetoConclusao { get; set; }
        public int CargaHorariaEstagio { get; set; }

        public Bacharelado(string nome, int carga) : base(nome)
        {
            CargaHorariaEstagio = carga;
        }

        public override decimal CalcularMensalidade()
        {
            return 0;
        }

        public decimal CalcularMensalidade(decimal desconto)
        {
            return 0;
        }

    }
}
