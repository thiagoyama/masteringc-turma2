using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Models
{
    class Loja : Estabelecimento
    {
        public int QuantidadeProdutos { get; set; }
        public TipoLoja Tipo { get; set; }

        public override decimal CalcularImposto(decimal faturamento)
        {
            return faturamento * 0.1m;
        }
    }

    enum TipoLoja
    {
        Roupa, Eletronicos, Calcados, Alimentos, CamaMesaBanho
    }
}
