using Fiap.Aula04.Models;
using System;

namespace Fiap.Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Fabricante
            Fabricante honda = new Fabricante() { Nome = "Honda" };

            //Instanciar um Carro
            Carro carro = new Carro();
            //Atribuir valores para as propriedades do carro
            carro.Motor = "1.0 TSI";
            carro.Cor = "Prata";
            carro.Ano = 2009;
            carro.ArCondicionado = true;
            carro.QuantidadePortas = 5;
            carro.Fabricante = honda;

            //Instanciar uma Moto
            //Atribuir valores para as propriedades da moto
            Moto cg = new Moto()
            {
                PartidaEletrica = true,
                Ano = 2021,
                Cor = "Vermelha",
                Motor = "120c",
                Fabricante = honda
            };

            //Instanciar um veiculo
            Veiculo veiculo = new Veiculo();
            //Atribuir valores para as propriedades do veículo
            veiculo.Ano = 2015;
            veiculo.Motor = "60HP";
            veiculo.Cor = "Branco";

            Veiculo veiculo2 = new Veiculo("Laranja", "100c", 2022);

            //Carro carro2 = new Carro("Rosa", "1.6", 2000); //Construtor não é herdado!

            //Chamando o método Acelerar()
            carro.Acelerar(); //Veículo
            cg.Acelerar(); //Moto
            veiculo.Acelerar(); //Veículo

            //Invocar as outras versões do método Acelerar
            carro.Acelerar(20); 
            carro.Acelerar(true, 20);

            //Instanciando o carro e motos utilizando os construtores com diferentes parâmetros
            Veiculo v1 = new Carro("Prata", "1.0", 2019, true, 3); //Carro é um veículo
            Veiculo v2 = new Carro(3); //Carro é um veículo
            Veiculo v3 = new Carro(); //Carro é um veículo
            Veiculo v4 = new Moto(); //Moto é um veiculo
            Veiculo v5 = new Moto("Preto", "300c", 2019, true); //Moto é um veiculo
            //Carro c1 = new Veiculo(); //Não compila, Veículo não é necessariamente um Carro
            //Moto m1 = new Veiculo(); //Não compila, Veículo não é necessariamente uma Moto

            v1.Acelerar(); //Veículo
            v4.Acelerar(); //Moto

            //Chamar o método frear do veiculo e do carro
            veiculo.Frear(100, false, 10); //Veiculo
            carro.Frear(100, false, 10); //Carro

            //Exibir os valores do veiculo, carro e moto
            Console.WriteLine("************************");
            Console.WriteLine($"Carro: {carro}");

            Console.WriteLine("************************");
            Console.WriteLine($"Moto: {cg}");

            Console.WriteLine("************************");
            Console.WriteLine($"Veículo: {veiculo}");

        }//main
    }//class
}//namespace
