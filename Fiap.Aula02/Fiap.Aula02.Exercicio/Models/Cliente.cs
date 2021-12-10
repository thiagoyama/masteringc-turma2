using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.Exercicio.Models
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        //prop -> tab tab
        //ctor -> tab tab
        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }
    }
}
