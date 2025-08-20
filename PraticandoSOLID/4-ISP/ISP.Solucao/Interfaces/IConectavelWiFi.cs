using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._4_ISP.ISP.Solucao.Interfaces
{
    public interface IConectavelWiFi
    {
        void ConectarWiFi(string senha);
        void DesconectarWiFi();
    }
}
