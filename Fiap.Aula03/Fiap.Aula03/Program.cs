using Fiap.Aula03.Models;
using System;

namespace Fiap.Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados da casa
            Console.WriteLine("Digite a quantidade de cômodos");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem piscina? (true/false)");
            var piscina = bool.Parse(Console.ReadLine());

            Console.WriteLine("Digite a área");
            var area = double.Parse(Console.ReadLine());

            //Instanciar a casa utilizando o construtor
            var casa = new Casa(qtd, piscina, area) ;

            var casa2 = new Casa(5, false, 100); //Valores definidos

            var casa3 = new Casa()
            { 
                Comodos = 5,
                AreaTotal = 50
            }; //Utiliza o construtor sem parâmetros

            var casa4 = new Casa(70) 
            {
                Piscina = true
            }; //Utiliza o construtor com 1 parâmetro

            //Exibir os dados do objeto Casa //CTRL + D -> duplica a linha
            Console.WriteLine($"{casa.Comodos}, {casa.Piscina}. {casa.AreaTotal}");
            Console.WriteLine($"{casa2.Comodos}, {casa2.Piscina}, {casa2.AreaTotal}");
            Console.WriteLine($"{casa3.Comodos}, {casa3.Piscina}, {casa3.AreaTotal}");
            Console.WriteLine($"{casa4.Comodos}, {casa4.Piscina}, {casa4.AreaTotal}");
        }
    }
}
