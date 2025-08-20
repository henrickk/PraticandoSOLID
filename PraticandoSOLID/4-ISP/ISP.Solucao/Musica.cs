using PraticandoSOLID._4_ISP.ISP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._4_ISP.ISP.Solucao
{
    public class Musica : IMusica
    {
        public void ReproduzirMusica(string musica)
        {
            Console.WriteLine($"Reproduzindo música: {musica}");
        }
        public void PausarMusica()
        {
            Console.WriteLine("Música pausada.");
        }
        public void PararMusica()
        {
            Console.WriteLine("Música parada.");
        }
    }
}
