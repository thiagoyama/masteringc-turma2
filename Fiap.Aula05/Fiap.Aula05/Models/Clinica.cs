using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Models
{
    class Clinica : Estabelecimento
    {
        public override decimal CalcularImposto(decimal faturamento)
        {
            return faturamento * 0.065m; //m para definir o valor do tipo decimal
        }
    }
}
