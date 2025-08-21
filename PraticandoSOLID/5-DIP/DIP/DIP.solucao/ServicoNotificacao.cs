using PraticandoSOLID._5_DIP.DIP.DIP.solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._5_DIP.DIP.DIP.solucao
{
    public class ServicoNotificacao
    {
        private readonly INotificacaoServices _notificacaoService;
        public ServicoNotificacao(INotificacaoServices notificacaoService)
        {
            _notificacaoService = notificacaoService; // ✅ alto nível depende de abstração
        }

        public void Processar(string usuario, string mensagem)
        {
            Console.WriteLine("🔔 Processando notificação...");
            _notificacaoService.Enviar(usuario, mensagem); // ✅ aceita qualquer tipo de notificação
        }
    }
}
