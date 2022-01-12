using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula05.Models
{
    //Classe abstrata -> não pode ser instanciada e pode conter métodos abstratos (sem implementação)
    abstract class Estabelecimento
    {
        //Propriedades
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        //Construtor

        //Métodos
        public abstract decimal CalcularImposto(decimal faturamento); //método abstrato, sem implementação

        public void CadastrarFuncionario(string nome)
        {
            Console.WriteLine($"Cadastrando o funcionário {nome} no estabelecimento {Nome}");
        }

        public bool ValidarCnpj()
        {
            if (Cnpj.Length < 20) //Valida se possui mais de 20 caracteres
            {
                return false;
            }
            return true;
        }

    }
}
