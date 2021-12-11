using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula03.Models
{
    class Casa
    {
        //Propriedades
        public int Comodos { get; set; }
        public bool Piscina { get; set; }
        public double AreaTotal { get; set; }

        //Construtores
        //Construtor que recebe todas as propriedades
        public Casa(int comodos, bool piscina, double areaTotal)
        {
            Comodos = comodos;
            Piscina = piscina;
            AreaTotal = areaTotal;
        }

        //Construtor que recebe somente a área
        public Casa(double areaTotal)
        {
            AreaTotal = areaTotal;
        }

        //Construtor padrão, sem parâmetros
        public Casa() { }

        //Métodos..
    }
}
