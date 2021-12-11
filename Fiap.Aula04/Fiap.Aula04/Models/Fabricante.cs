using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Models
{
    class Fabricante
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Fabricante: {Nome}";
        }
    }
}
