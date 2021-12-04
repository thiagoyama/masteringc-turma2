using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula01.Exercicio02.Models
{
    class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Comprimento { get; set; }
        public Cor Cor { get; set; }
        public string Placa { get; set; }
        public decimal Valor { get; set; }
        public bool ArCondicionado { get; set; }
    }
}
