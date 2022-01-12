using Fiap.Aula06.Exemplo.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula06.Exemplo.Services
{
    class EmailMessage : IMessage
    {
        public void SendMessage(string msg)
        {
            //Valida se a mensagem tem pelo menos 10 caracteres
            if (msg.Length < 10)
            {
                //Lança a exception
                throw new InvalidMessageException();
            }
            Console.WriteLine($"Enviando um email com a mensagem {msg}");
        }

        public void SendMessage(string msg, string subject)
        {
            Console.WriteLine($"Enviando um email {subject}, msg {msg}");
        }
    }
}
