using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio02.Models
{
    class Eletronico : Produto
    {
        public bool Garantia { get; set; }

        public Eletronico(int id, string nome) : base (id, nome) { }

        public decimal CalcularGarantiaEstendida()
        {
            //if (Garantia)
            //    return Preco * 0.1m; //m define o valor do tipo decimal
            //return 0;
            return Garantia ? Preco * 0.1m : 0;
        }
    }
}
