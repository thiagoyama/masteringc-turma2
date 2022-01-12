using Fiap.Aula06.Exemplo.Exceptions;
using Fiap.Aula06.Exemplo.Services;
using System;

namespace Fiap.Aula06.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            try //Código que pode gerar uma exception
            {
                //Ler uma idade
                Console.WriteLine("Digite a idade");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine($"A idade é {idade}");
            }
            catch (FormatException) //Captura da exception e o tratamento
            {
                Console.WriteLine("Número inválido");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro genérico");
            }
            finally //Bloco que sempre executa
            {
                Console.WriteLine("Bloco que sempre executa");
            }

            //Instanciar um tipo de IMessage
            IMessage service = new EmailMessage();

            //Ler a mensagem
            Console.WriteLine("Digite uma mensagem");
            var msg = Console.ReadLine();

            try
            {
                //Chamar o método para enviar uma mensagem
                service.SendMessage(msg);
            }
            catch (InvalidMessageException)
            {
                Console.WriteLine("Mensagem inválida");
            }
        }
    }
}
