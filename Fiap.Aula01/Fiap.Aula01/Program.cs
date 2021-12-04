using System;
using Fiap.Aula01.Models;

namespace Fiap.Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar um objeto do tipo Cliente (instanciar)
            Cliente cliente = new Cliente();      

            cliente.Nome = "João"; //Set
            cliente.Idade = -10; //Set
            cliente.Altura = 1.8f; //f para definir que o número é do tipo float

            Console.WriteLine($"Idade {cliente.Idade}");

            //Ternário
            //int i = 0;
            //char sala = (i == 0 ? 'A' : 'B');

            //Criar outro objeto do tipo Cliente
            Cliente hete = new Cliente();
            hete.Nome = "Héte"; //Set
            hete.Altura = 1.74f;
            hete.Idade = 40;

            //Criar um objeto do tipo Endereço
            Endereco end = new Endereco();
            end.Logradouro = "Av Paulista";
            end.Cep = "84521-521";
            end.Cidade = "São Paulo";
            end.Numero = "123";

            //Atribuir um endereço para o hete
            hete.Endereco = end;

            //Exibir alguns dados do cliente, inclusive do endereço
            Console.WriteLine($"Nome do cliente {hete.Nome}, Idade: {hete.Idade}," +
                $" Cidade: {hete.Endereco.Cidade}"); //Get
        }
    }
}
