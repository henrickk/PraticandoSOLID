using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._4_ISP.ISP.Violacao
{
    public class Lampada : IDispositivo
    {
        public void Ligar() => Console.WriteLine("Lâmpada ligada");
        public void Desligar() => Console.WriteLine("Lâmpada desligada");

        public void ConectarWiFi()
        {
            // Não faz sentido para lâmpada básica
            throw new NotImplementedException();
        }

        public void ReproduzirMusica(string musica)
        {
            // Não faz sentido
            throw new NotImplementedException();
        }

        public void MostrarVideo(string url)
        {
            // Não faz sentido
            throw new NotImplementedException();
        }
    }

}
