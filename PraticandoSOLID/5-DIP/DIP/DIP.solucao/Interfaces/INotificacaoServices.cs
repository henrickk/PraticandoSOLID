using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._5_DIP.DIP.DIP.solucao.Interfaces
{
    public interface INotificacaoServices
    {
        void Enviar(string destino, string mensagem);
    }
}
