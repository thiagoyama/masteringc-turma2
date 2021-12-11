using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Models
{
    class Moto : Veiculo
    {
        public bool PartidaEletrica { get; set; }

        //Construtor que invoca o construtor do veiculo com 3 parâmetros
        public Moto(string cor, string motor, int ano, bool partida) : base(cor, motor, ano)
        {
            PartidaEletrica = partida;
        }

        public Moto() { }

        //Sobrescrever o método Acelerar do classe Pai
        //Implementar o mesmo método da classe pai, adicionando ou modificando o comportamento
        public override void Acelerar()
        {
            Console.WriteLine("Moto acelerando...");
        }

        public override string ToString()
        {
            return base.ToString() + $", Partida elétrica: {(PartidaEletrica?"Sim":"Não")}";
        }

    }
}
