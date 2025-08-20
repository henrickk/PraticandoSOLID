using PraticandoSOLID._4_ISP.ISP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._4_ISP.ISP.Solucao
{
    public abstract class DispositivoLigavelBase : ILigavel
    {
        public virtual void Ligar()
        {
            Console.WriteLine($"{this.GetType().Name} ligado.");
        }

        public virtual void Desligar()
        {
            Console.WriteLine($"{this.GetType().Name} desligado.");
        }
    }
}
