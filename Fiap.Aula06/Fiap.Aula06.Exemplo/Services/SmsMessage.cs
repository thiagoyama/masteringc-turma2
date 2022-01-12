using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula06.Exemplo.Services
{
    class SmsMessage : IMessage
    {

        public void SendMessage(string msg)
        {
            Console.WriteLine($"Enviando um sms com a mensagem {msg}");
        }

        public void SendMessage(string msg, string subject)
        {
            Console.WriteLine($"Enviando um sms {subject}, \nmensagem: {msg}");
        }
    }
}
