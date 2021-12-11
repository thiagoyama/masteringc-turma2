using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Models
{
    class Carro : Veiculo
    {
        public bool ArCondicionado { get; set; }
        public int QuantidadePortas { get; set; }

        //Construtor que invoca o construtor do pai com 3 parâmetros
        public Carro(string cor, string motor, int ano, bool ar, int portas)
                                                                    : base(cor, motor, ano)
        {
            ArCondicionado = ar;
            QuantidadePortas = portas;
        }

        //Construtores que invocam o construtor padrão da classe veiculo
        public Carro() { }

        public Carro(int quantidade) 
        {
            QuantidadePortas = quantidade;
        }

        //Sobrescrever o método Frear, para parar 80% mais devagar
        public override void Frear(double velocidadeAtual, bool parado, double velocidadeFrenagem)
        {
            //Exemplo de adição de um comportamento no método do pai
            var velocidadeFrenagemCarro = velocidadeFrenagem * 0.8;
            Console.WriteLine($"Nova velocidade de frenagem {velocidadeFrenagemCarro}");
            //Chama o método do pai através do base
            base.Frear(velocidadeAtual, parado, velocidadeFrenagemCarro);
        }

        public override string ToString()
        {
            //Chama o método Tostring do Veiculo
            return base.ToString() 
                + $", Ar-condicionado: {(ArCondicionado?"Tem":"Não tem")}, Número de portas: {QuantidadePortas}";
        }

    }
}
