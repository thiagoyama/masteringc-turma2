using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula04.Models
{
    class Veiculo
    {
        public string Cor { get; set; }
        public string Motor { get; set; }
        public int Ano { get; set; }
        public Fabricante Fabricante { get; set; }

        public Veiculo(string cor, string motor, int ano)
        {
            Cor = cor;
            Motor = motor;
            Ano = ano;
        }

        public Veiculo() { }

        //virtual -> permite a sobrescrita do método nas classes filhas
        public virtual void Acelerar()
        {
            Console.WriteLine("Veículo acelerando...");
        }

        //Sobrecarregar o método Acelerar, implementar mais uma versão do método com parâmetros diferentes
        public void Acelerar(double aceleracao)
        {
            Console.WriteLine($"Veículo acelerando a {aceleracao} m/s");
        }

        public double Acelerar(bool turbo, double velocidade)
        {  
            var velocidadeFinal = turbo ? velocidade * 10 : velocidade;
            Console.WriteLine($"Veículo acelerando a {velocidadeFinal}, possui turbo: {turbo}");
            return velocidadeFinal;
        }

        public virtual void Frear(double velocidadeAtual, bool parado, double velocidadeFrenagem)
        {
            var velocidadeFinal = !parado ? velocidadeAtual - velocidadeFrenagem : 0;
            Console.WriteLine($"Velocidade atual: {velocidadeFinal}");
        }

        //Sobrescrever o método ToString() para exibir os dados do veículo
        public override string ToString()
        {
            return $"Cor: {Cor}, Motor: {Motor}, Ano: {Ano}, {Fabricante}";
        }

    }
}
