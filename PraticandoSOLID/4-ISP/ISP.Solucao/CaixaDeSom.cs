using PraticandoSOLID._4_ISP.ISP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._4_ISP.ISP.Solucao
{
    public class CaixaDeSom : DispositivoLigavelBase, IMusica
    {
        private readonly IMusica musica;

        public CaixaDeSom(IMusica musica)
        {
            this.musica = musica;
        }

        public void PararMusica()
        {
            throw new NotImplementedException();
        }

        public void PausarMusica()
        {
            throw new NotImplementedException();
        }

        public void ReproduzirMusica(string musica)
        {
            this.musica.ReproduzirMusica(musica);
        }



    }
}
