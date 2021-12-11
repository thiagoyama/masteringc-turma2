using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio01.Models
{
    class Lancha : Veiculo
    {
        public float Peso { get; set; }
        public float AlturaCarreta { get; set; }
        public int QuantidadeMotores { get; set; }
    }
}
