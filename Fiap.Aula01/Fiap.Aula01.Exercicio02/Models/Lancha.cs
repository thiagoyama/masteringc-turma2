using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula01.Exercicio02.Models
{
    class Lancha
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Comprimento { get; set; }
        public Cor Cor { get; set; }
        public float Peso { get; set; }
        public decimal Valor { get; set; }
        public float AlturaCarreta { get; set; }
        public int QuantidadeMotores { get; set; }
    }
}
