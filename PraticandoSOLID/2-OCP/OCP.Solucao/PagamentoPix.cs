using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._2_OCP.OCP.Solucao
{
    public class PagamentoPix : PagamentoBase
    {
        public override void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento realizado com sucesso no valor de: {valor} via Pix! ");
        }
    }
}
