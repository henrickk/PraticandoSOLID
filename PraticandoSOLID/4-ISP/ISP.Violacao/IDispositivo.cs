using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._4_ISP.ISP.Violacao
{
    public interface IDispositivo
    {
        void Ligar();
        void Desligar();
        void ConectarWiFi();
        void ReproduzirMusica(string musica);
        void MostrarVideo(string url);
    }

}
