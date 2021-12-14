using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio03.Models
{
    //Classe abstrata -> não pode ser instanciada e pode conter métodos abstratos (sem implementação)
    abstract class Formacao
    {
        public string Nome { get; set; }
        public int Duracao { get; protected set; }
        public decimal Mensalidade { get; protected set; }
        public Instituicao Instituicao { get; set; }

        public Formacao(string nome)
        {
            Nome = nome;
            DefinirDuracao();
        }

        public abstract void DefinirDuracao();

        public float CalcularMedia(float nota1, float nota2)
        {
            return (nota1 + nota2) / 2;
        }

        public float CalcularMedia(float nota1, float nota2, float nota3)
        {
            if (nota1 < nota2 && nota1 < nota3)
            {
                return CalcularMedia(nota2, nota3);
            }
            else if (nota2 < nota1 && nota2 < nota3)
            {
                return CalcularMedia(nota1, nota3);
            }
            return CalcularMedia(nota1, nota2);
        }

        public virtual decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 400;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Duração: {Duracao}, Mensalidade: {Mensalidade}, {Instituicao}";
        }
    }
}
