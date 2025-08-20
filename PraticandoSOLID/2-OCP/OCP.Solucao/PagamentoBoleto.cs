using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._2_OCP.OCP.Solucao
{
    public class PagamentoBoleto : PagamentoBase
    {
        public override void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento realizado com sucesso no valor de: {valor} via Boleto!");
        }
    }
}
