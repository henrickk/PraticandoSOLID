using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._5_DIP.DIP.DIP.violacao
{
    public class NotificacaoEmail
    {
        public void Enviar(string destino, string mensagem)
        {
            Console.WriteLine($"📧 Enviando EMAIL para {destino}: {mensagem}");
        }
    }

    public class ServicoNotificacao
    {
        private readonly NotificacaoEmail _notificacaoEmail;

        public ServicoNotificacao()
        {
            _notificacaoEmail = new NotificacaoEmail(); // ❌ alto nível depende de baixo nível
        }

        public void Processar(string usuario, string mensagem)
        {
            Console.WriteLine("🔔 Processando notificação...");
            _notificacaoEmail.Enviar(usuario, mensagem); // ❌ só aceita e-mail

        }
    }
}