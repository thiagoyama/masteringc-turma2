using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula06.Exemplo.Services
{
    interface IMessage
    {
        void SendMessage(string msg);

        void SendMessage(string msg, string subject);
    }
}
