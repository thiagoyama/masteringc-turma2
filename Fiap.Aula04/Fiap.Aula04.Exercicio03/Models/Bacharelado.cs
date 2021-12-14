using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Exercicio03.Models
{
    class Bacharelado : Formacao
    {
        public string ProjetoConclusao { get; set; }
        public int CargaHorariaEstagio { get; set; }

        public Bacharelado(string nome, int carga) : base(nome)
        {
            CargaHorariaEstagio = carga;
        }

        public override decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 600 + CargaHorariaEstagio * 12;
        }

        //Valor absoluto do desconto (Ex. 10%)
        public decimal CalcularMensalidade(decimal desconto)
        {
            return Mensalidade = CalcularMensalidade() - CalcularMensalidade()*desconto/100;
        }

        public override void DefinirDuracao()
        {
            //Contains() -> Método para verificar se possui a palavra pesquisada
            //ToLower() -> Método que transforma os caracteres para minusculas
            if (Nome.ToLower().Contains("engenharia")) 
            {
                Duracao = 60;
            }
            else
            {
                Duracao = 48;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" Projeto: {ProjetoConclusao}, Carga horária estágio: {CargaHorariaEstagio}";
        }

    }
}
