using PraticandoSOLID._4_ISP.ISP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._4_ISP.ISP.Solucao
{
    public class SmartTV : DispositivoLigavelBase, IVideo, IConectavelWiFi
    {
        private readonly IVideo _video;
        private readonly IConectavelWiFi _wifi;

        public SmartTV(IVideo video, IConectavelWiFi wifi)
        {
            _video = video;
            _wifi = wifi;
        }

        public void MostrarVideo(string url)
        {
            _video.MostrarVideo(url);
        }

        public void ConectarWiFi(string senha)
        {
            _wifi.ConectarWiFi(senha);
        }

        public void DesconectarWiFi()
        {
            _wifi.DesconectarWiFi();
            Console.WriteLine("Smart TV desconectada do WiFi.");
        }
    }
}
