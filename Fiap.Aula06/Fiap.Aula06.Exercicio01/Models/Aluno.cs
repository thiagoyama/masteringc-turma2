using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula06.Exercicio01.Models
{
    class Aluno
    {
        public string Nome { get; set; }
        public float Media { get; set; }
        public Genero Genero { get; set; }
    }

    enum Genero
    {
        Feminino, Masculino, Outros
    }
}
