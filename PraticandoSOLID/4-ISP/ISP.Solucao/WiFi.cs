using PraticandoSOLID._4_ISP.ISP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._4_ISP.ISP.Solucao
{
    public class WiFi : IConectavelWiFi
    {
        public void ConectarWiFi(string senha)
        {
            Console.WriteLine($"Conectando à rede WiFi com a senha: {senha}");
        }

        public void DesconectarWiFi()
        {
            Console.WriteLine("Desconectando do WiFi.");
        }

    }
}
