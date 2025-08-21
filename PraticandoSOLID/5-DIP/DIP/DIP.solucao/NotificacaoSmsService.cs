using PraticandoSOLID._5_DIP.DIP.DIP.solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._5_DIP.DIP.DIP.solucao
{
    public class NotificacaoSmsService : INotificacaoServices
    {
        public void Enviar(string destino, string mensagem)
        {
            Console.WriteLine($"📱 Enviando SMS para {destino}: {mensagem}");
        }
    }
}
